using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactionTest.Hardware
{
    public interface IHardware
    {
        void SetOutput(int outputNumber, bool state);
        int ReadInput();
    }
}
