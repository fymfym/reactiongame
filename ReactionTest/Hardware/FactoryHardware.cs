using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ReactionTest.Hardware
{
    public class FactoryHardware
    {
        public IHardware Setup()
        {                
            var res = new VM167();
            return res;
        }
    }
}
