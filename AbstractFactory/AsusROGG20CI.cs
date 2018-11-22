using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AsusROGG20CI : IDesktop
    {
        public string GetDetailsModele()
        {
            return "Asus ROG G20CI, Intel Core i7-7700 3.60 GHz, 16GB RAM DDR4, SSD 512GB, NVIDIA GeForce GTX 1070 8GB - 1600$";
        }
    }
}
