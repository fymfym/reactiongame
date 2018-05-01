using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReactionTest.Game;
using ReactionTest.Hardware;

namespace ReactionTest
{
    public partial class Form1 : Form
    {
        private int _pointSucess;
        private int _pointError;
        private long _pressTimesum;
        private long _gamesRun;

        public delegate void OnString(string message);
        public delegate void DelegateVoid();


        private Hardware.IHardware _hardware;
        private Game.IGame _game;

        private bool _but1;
        private bool _but2;
        private bool _but3;

        public Form1()
        {
            InitializeComponent();
            _pointSucess = 0;
            _pointError = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _hardware = new Hardware.FactoryHardware().Setup();
            PrepareGame();
        }

        private void GameOnOnGameStop()
        {
            SoundPlayer player = new SoundPlayer("game/sounds/end.wav");
            player.Play();
            player.Play();
            UpdateScoreScreen();
        }

        private void GameOnOnGameResult(IGameResult gameSucess)
        {
            _gamesRun++;
            WriteLog($"Game result:{gameSucess.Success} time:{gameSucess.ReactiontimeMillisseconds}");
            if (gameSucess.Success)
            {
                _pointSucess++;
                _pressTimesum += gameSucess.ReactiontimeMillisseconds;
            }
            else
            {
                _pointError++;
            }

            UpdateScoreScreen();
        }

        private void UpdateScoreScreen()
        {
            if (lblErrors.InvokeRequired)
            {
                var d = new DelegateVoid(UpdateScoreScreen);
                this.BeginInvoke(d, null);
            }
            else
            {
                lblGood.Text = $"{_pointSucess}";
                lblErrors.Text = $"{_pointError}";
                if (_gamesRun > 0)
                    lblAverageTime.Text = (_pressTimesum / _gamesRun).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _but1 = !_but1;
            SetButtons();
        }

        void SetButtons()
        {
            _hardware.SetOutput(1, _but1);
            _hardware.SetOutput(2, _but2);
            _hardware.SetOutput(3, _but3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _but2 = !_but2;
            SetButtons();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            _but3 = !_but3;
            SetButtons();

        }

        private void WriteLog(string message)
        {
            if (txtLog.InvokeRequired)
            {
                var d = new OnString(WriteLog);
                this.BeginInvoke(d, message);
            }
            else
            {
                txtLog.AppendText($"{message}" + Environment.NewLine);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("game/sounds/start.wav");
            player.Play();

            _game.StartGame();
            _gamesRun = 0;
            _pointSucess = 0;
            _pointError = 0;
            _pressTimesum = 0;
            UpdateScoreScreen();
            WriteLog("Tryk på den der lyser");
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openDebugscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmTest(_hardware);
            frm.ShowDialog();
        }

        private void reactionsTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game = new GameFactory().Construct(GameFactory.GameTypes.PressTheLitButton);
            PrepareGame();
        }

        void PrepareGame()
        {
            if (_game == null)
            {
                btnStartGame.Enabled = false;
                btnStopGame.Enabled = false;
                return;
            }

            _game.OnGameStop += GameOnOnGameStop;
            _game.OnGameResult += GameOnOnGameResult;
            _game.SetUp(_hardware);

            btnStartGame.Enabled = true;
            btnStopGame.Enabled = true;

        }

        private void gentagRækkefølgenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game = new GameFactory().Construct(GameFactory.GameTypes.RepeatTheCombination);
            PrepareGame();

        }
    }
}
