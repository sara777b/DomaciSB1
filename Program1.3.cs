using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciSB1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celzijus, kelvin, farenhajt, x = 273, y = 18, z = 10, e = 32;
            string stringCelzijus; 

            Console.Write("Izrazite temperaturu u celzijusima (°): ");
            stringCelzijus = Console.ReadLine();

            celzijus = int.Parse(stringCelzijus);

            kelvin = celzijus + x;
            farenhajt = celzijus * y / z + e;

            Console.WriteLine("Temperatura u kelvinima (K) je: " + kelvin);
            Console.WriteLine("Temperatura u farenhajtima (F) je: " + farenhajt);
            Console.ReadKey();
        }
    }
}
