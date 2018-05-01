using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using ReactionTest.Hardware;

namespace ReactionTest.Game
{
    public class PressTheLitButton : IGame
    {
        private enum EState
        {
            Init,
            InitBlink1,
            InitBlink2,
            InitBlink3,
            GameReady,
            LightButton,
            AwiatingPress,
            CoolDown,
            CoolDownTimer,
            Stopped
        }

        private Int16 _lastButton;
        private IHardware _hardware;
        private EState _state;
        private int _timerCount;
        private System.Timers.Timer _timer;
        private Random _random;
        private int _buttonNumber;
        private Stopwatch _stopwatch;
        private int _gameRepeats;

        public event OnGameStopDelegate OnGameStop;
        public event OnGameresultDelegate OnGameResult;

        public void SetUp(IHardware hardware)
        {
            _random = new Random((int)DateTime.Now.Ticks);
            _hardware = hardware;
            _state = EState.Init;
            SetAllOutput(false);

            _timerCount = 0;
            _timer = new System.Timers.Timer();
            _timer.Elapsed += TimerOnElapsed;
            _timer.Interval = 2;
            _timer.Enabled = true;
            _stopwatch = new Stopwatch();
            _gameRepeats = -1;
        }

        public void StartGame()
        {
            _state = EState.LightButton;
            _stopwatch.Reset();
            _stopwatch.Start();
            _timer.Start();
            _gameRepeats = 10;
        }

        public void StopGame()
        {
            _timer.Enabled = false;
            OnGameStop?.Invoke();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            if (_gameRepeats == 0) 
            {
                StopGame();
                _state = EState.Stopped;
            }

            switch (_state)
            {
                case EState.Init:
                    if (_timerCount == 0)
                    {
                        SetAllOutput(true);
                        _timerCount++;
                        break;
                    }

                    _timerCount++;

                    if (_timerCount > 10)
                    {
                        _state = EState.InitBlink1;
                        _timerCount = 0;
                    }
                    break;

                case EState.InitBlink1:
                    if (_timerCount == 0)
                    {
                        SetAllOutput(false);
                        _timerCount++;
                        break;
                    }

                    _timerCount++;

                    if (_timerCount > 5)
                    {
                        _state = EState.InitBlink2;
                        _timerCount = 0;
                    }
                    break;

                case EState.InitBlink2:
                    if (_timerCount == 0)
                    {
                        SetAllOutput(true);
                        _timerCount++;
                        break;
                    }

                    _timerCount++;

                    if (_timerCount > 10)
                    {
                        _state = EState.InitBlink3;
                        _timerCount = 0;
                    }
                    break;

                case EState.InitBlink3:
                    SetAllOutput(false);
                    _state = EState.GameReady;
                    break;

                case EState.GameReady:
                    break;

                case EState.LightButton:
                    _buttonNumber = GetbuttonToLight();
                    _hardware.SetOutput(_buttonNumber, true);
                    _timerCount = 0;
                    _state = EState.AwiatingPress;
                    _stopwatch.Restart();
                    break;

                case EState.AwiatingPress:
                    _timerCount++;
                    if (_timerCount > 250)
                    {
                        SetAllOutput(false);
                        _state = EState.CoolDown;
                        _stopwatch.Stop();

                        IGameResult gameResult = new GameResult();
                        gameResult.Success = false;
                        gameResult.ReactiontimeMillisseconds = _stopwatch.ElapsedMilliseconds;
                        OnGameResult?.Invoke(gameResult);
                    }

                    int input = _hardware.ReadInput();
                    if (input > 0)
                    {
                        _stopwatch.Stop();
                        SetAllOutput(false);
                        _state = EState.CoolDown;
                        IGameResult gameResult = new GameResult();
                        gameResult.ReactiontimeMillisseconds = _stopwatch.ElapsedMilliseconds;
                        gameResult.Success = input == _buttonNumber;
                        OnGameResult?.Invoke(gameResult);
                    }

                    break;

                case EState.CoolDown:
                    _gameRepeats--;
                    _timerCount = 0;
                    _state = EState.CoolDownTimer;
                    break;

                case EState.CoolDownTimer:
                    _timerCount++;
                    if (_timerCount > 10)
                    {
                        _state = EState.LightButton;
                    }
                    break;


            }
        }

        private byte GetbuttonToLight()
        {
            byte t = GetNumber();
            while (t == _lastButton)
                t = GetNumber();
            _lastButton = t;
            return t;
        }

        private byte GetNumber()
        {
            int t = _random.Next(1, 99);
            if (t <= 33) return 1;
            if (t >= 66) return 3;
            return 2;
        }

        private void SetAllOutput(bool state)
        {
            _hardware.SetOutput(1, state);
            _hardware.SetOutput(2, state);
            _hardware.SetOutput(3, state);

        }
    }
}
