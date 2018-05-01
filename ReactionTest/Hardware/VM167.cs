using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactionTest.Hardware
{
    public class VM167 : IHardware
    {
        private Velmann167.VelmannVm167UsbDriver _vel;
        private int _buttonValuesNew;
        private const int MaxCount = 5;

        public VM167()
        {
            _vel = new Velmann167.VelmannVm167UsbDriver();
            _vel.SetupUsb(0, false, true);
        }

        public void SetOutput(int outputNumber, bool state)
        {
            _vel.SetDigitalOutput(outputNumber, state);
        }

        public int ReadInput()
        {
            _buttonValuesNew = _vel.ButtonValues;

            if ((_buttonValuesNew & 16) == 16)
            {
                return 1;
            }

            if ((_buttonValuesNew & 32) == 32)
            {
                return 2;
            }

            if ((_buttonValuesNew & 64) == 64)
            {
                return 3;
            }

            return 0;
        }
    }
}

