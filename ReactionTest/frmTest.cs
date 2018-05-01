using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReactionTest.Hardware;

namespace ReactionTest
{
    public partial class frmTest : Form
    {
        private IHardware _hardware;
        private bool _out1State;
        private bool _out2State;
        private bool _out3State;

        public frmTest(IHardware hardware)
        {
            _hardware = hardware;
            _out1State = false;
            _out1State = false;
            _out1State = false;
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnLight1_Click(object sender, EventArgs e)
        {
            _out1State = !_out1State;
            _hardware.SetOutput(1,_out1State);
        }

        private void btnLight2_Click(object sender, EventArgs e)
        {
            _out2State = !_out2State;
            _hardware.SetOutput(2, _out2State);
        }

        private void btnLight3_Click(object sender, EventArgs e)
        {
            _out3State = !_out3State;
            _hardware.SetOutput(3, _out3State);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var input = _hardware.ReadInput();
            if (input == 1)
            {
                lblButton1State.Text = "ON";
            }
            else
            {
                lblButton1State.Text = "OFF";
            }

            if (input == 2)
            {
                lblButton2State.Text = "ON";
            }
            else
            {
                lblButton2State.Text = "OFF";
            }

            if (input == 3)
            {
                lblButton3State.Text = "ON";
            }
            else
            {
                lblButton3State.Text = "OFF";
            }


        }
    }
}
