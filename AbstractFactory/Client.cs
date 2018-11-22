using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Client
    {
        ILaptop     laptop;
        IDesktop    desktop;

        public Client(IOrdinateur factory)
        {
            laptop = factory.GetLaptop();
            desktop = factory.GetDesktop();
        }

        public string GetLaptopDetailsModele()
        {
            return laptop.GetDetailsModele();
        }

        public string GetDesktopDetailsModele()
        {
            return desktop.GetDetailsModele();
        }
    }
}
