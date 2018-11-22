using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AsusVivoBook : ILaptop
    {
        public string GetDetailsModele()
        {
            return "Asus Vivobook 15.6 in, Intel Core i5-8250U, 8GB RAM, SSD 256GB - 700$";
        }
    }
}