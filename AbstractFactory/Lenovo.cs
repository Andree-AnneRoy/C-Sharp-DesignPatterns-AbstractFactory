using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Lenovo : IOrdinateur
    {
        public IDesktop GetDesktop()
        {
            return new LenovoThinkCenter();
        }

        public ILaptop GetLaptop()
        {
            return new LenovoIdeaPad();
        }
    }
}
