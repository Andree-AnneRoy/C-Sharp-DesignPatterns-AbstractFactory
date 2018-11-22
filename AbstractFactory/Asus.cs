using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Asus : IOrdinateur
    {
        public IDesktop GetDesktop()
        {
            return new AsusROGG20CI();
        }

        public ILaptop GetLaptop()
        {
            return new AsusVivoBook();
        }
    }
}
