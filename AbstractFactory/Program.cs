using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrdinateur asusOrdinateur = new Asus();
            Client asusClient = new Client(asusOrdinateur);

            Console.WriteLine("******** ASUS ********");
            Console.WriteLine(asusClient.GetDesktopDetailsModele());
            Console.WriteLine(asusClient.GetLaptopDetailsModele());


            IOrdinateur lenovoOrdinateur = new Lenovo();
            Client lenovoClient = new Client(lenovoOrdinateur);

            Console.WriteLine("******** LENOVO ********");
            Console.WriteLine(lenovoClient.GetDesktopDetailsModele());
            Console.WriteLine(lenovoClient.GetLaptopDetailsModele());

            Console.ReadLine();
        }
    }
}
