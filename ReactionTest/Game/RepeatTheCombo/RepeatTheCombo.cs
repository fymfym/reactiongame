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
    public class RepeatTheCombo : IGame
    {
        private const int SHOWCOMBINATIONONSHOWTIME = 50;
        private const int SHOWCOMBINATIONOFFTIME = 50;

        private enum EState
        {
            TimerOn,
            Init,
            ShowCombinationOn,
            ShowCombinationOnPause,
            ShowCombinationOff,
            ShowCombinationOffPause,
            WaitToStart,
            WaitToStartOff,
            PrepareStart,
            AwaitingCombination,
            ShiftToNext,
            Stopped
        }

        private IHardware _hardware;
        private EState _state;
        private System.Timers.Timer _timer;
        private Random _random;
        private int _gameRepeats;
        private List<int> _combinations;
        private int _combinationIndex;
        private int _combinationLength;
        private int _timerCount;
        private int _lastButton;

        public event OnGameStopDelegate OnGameStop;
        public event OnGameresultDelegate OnGameResult;

        public void SetUp(IHardware hardware)
        {
            _random = new Random((int)DateTime.Now.Ticks);
            _hardware = hardware;
            _state = EState.TimerOn;
            SetAllOutput(false);

            _timer = new System.Timers.Timer();
            _timer.Elapsed += TimerOnElapsed;
            _timer.Interval = 2;
            _timer.Enabled = true;
            _gameRepeats = -1;
            _combinationLength = 3;
        }

        private List<int> CreateCombination(int numberOfElementsToCreate)
        {
            var res = new List<int>();
            for (int i = 0; i < numberOfElementsToCreate; i++)
            {
                res.Add(GetNumber());
            }

            return res;
        }

        public void StartGame()
        {
            _combinations = CreateCombination(_combinationLength);

            _state = EState.Init;
            _timer.Start();
            _gameRepeats = 10;
            _timerCount = 0;
        }

        public void StopGame()
        {
            _timer.Enabled = false;
            OnGameStop?.Invoke();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            _timerCount++;

            if (_gameRepeats == 0)
            {
                StopGame();
                _state = EState.Stopped;
            }

            switch (_state)
            {
                case EState.Init:
                    _combinationIndex = 0;
                    SetAllOutput(true);
                    if (_timerCount > 50)
                    {
                        SetAllOutput(false);
                        _state = EState.ShowCombinationOn;
                        _timerCount = 0;
                        _combinationIndex = 0;
                    }
                    break;

                case EState.ShowCombinationOn:
                    _hardware.SetOutput(_combinations[_combinationIndex], true);
                    _state = EState.ShowCombinationOnPause;
                    _timerCount = 0;
                    break;

                case EState.ShowCombinationOnPause:
                    if (_timerCount > SHOWCOMBINATIONONSHOWTIME)
                    {
                        _state = EState.ShowCombinationOff;
                        _timerCount = 0;
                    }
                    break;

                case EState.ShowCombinationOff:
                    SetAllOutput(false);
                    _timerCount = 0;
                    _state = EState.ShowCombinationOffPause;
                    break;


                case EState.ShowCombinationOffPause:

                    if (_timerCount > SHOWCOMBINATIONOFFTIME)
                    {
                        _state = EState.ShowCombinationOn;
                        _timerCount = 0;

                        _combinationIndex++;
                        if (_combinationIndex >= _combinations.Count)
                        {
                            _state = EState.WaitToStart;
                            _timerCount = 0;
                            break;
                        }

                    }

                    break;

                case EState.WaitToStart:
                    if (_timerCount > 100)
                    {
                        SetAllOutput(true);
                        _timerCount = 0;
                        _state = EState.WaitToStartOff;
                    }

                    //int input = _hardware.ReadInput();

                    break;

                case EState.WaitToStartOff:
                    if (_timerCount > 50)
                    {
                        SetAllOutput(false);
                        _timerCount = 0;
                        _state = EState.PrepareStart;
                    }


                    break;

                case EState.PrepareStart:
                    if (_timerCount > 10)
                    {
                        _state = EState.AwaitingCombination;
                        _combinationIndex = 0;
                        _timerCount = 0;
                    }

                    break;

                case EState.AwaitingCombination:
                    int input = _hardware.ReadInput();
                    if (input > 0)
                    {
                        IGameResult gameResult = new GameResult();
                        gameResult.ReactiontimeMillisseconds = 0;
                        gameResult.Success = input == _combinations[_combinationIndex];
                        OnGameResult?.Invoke(gameResult);
                        _state = EState.ShiftToNext;
                    }

                    if (_timerCount > 250)
                    {
                        IGameResult gameResult = new GameResult();
                        gameResult.ReactiontimeMillisseconds = 0;
                        gameResult.Success = false;
                        OnGameResult?.Invoke(gameResult);
                        _state = EState.ShiftToNext;
                    }
                    break;

                case EState.ShiftToNext:
                    if (_hardware.ReadInput() == 0)
                    {
                        _combinationIndex++;
                        if (_combinationIndex >= _combinations.Count)
                        {
                            SetAllOutput(true);
                        }
                        else _state = EState.AwaitingCombination;
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
