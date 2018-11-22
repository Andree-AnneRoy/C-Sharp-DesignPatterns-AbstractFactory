using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class LenovoIdeaPad : ILaptop
    {
        public string GetDetailsModele()
        {
            return "Lenovo IdeaPad 15.6 in, AMD A12-9720P, 8GB RAM, HDD 1TB, AMD Radeon R7 - 500$";
        }
    }
}
