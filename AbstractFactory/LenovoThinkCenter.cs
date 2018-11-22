using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class LenovoThinkCenter : IDesktop
    {
        public string GetDetailsModele()
        {
            return "Lenovo ThinkCenter M710e SFF, Intel Core i5-7400 3.0 GHz, 8GB RAM DDR4, HDD 1TB - 700$";
        }
    }
}
