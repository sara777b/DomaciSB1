using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciSB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prvi, drugi, rezultats, rezultato, rezultatm, rezultatd, rezultatostatak;
            string stringPrvi, stringDrugi;

            Console.Write("Unesite prvi broj: ");
            stringPrvi = Console.ReadLine();
            Console.Write("Unesite drugi broj: ");
            stringDrugi = Console.ReadLine();

            prvi = int.Parse(stringPrvi);
            drugi = int.Parse(stringDrugi);

            rezultats = prvi + drugi;
            rezultato = prvi - drugi;
            rezultatm = prvi * drugi;
            rezultatd = prvi / drugi;
            rezultatostatak = prvi % drugi;

            Console.WriteLine(prvi + " " + "+" + " " + drugi + " " + "=" + " " + rezultats);
            Console.WriteLine(prvi + " " + "-" + " " + drugi + " " + "=" + " " + rezultato);
            Console.WriteLine(prvi + " " + "*" + " " + drugi + " " + "=" + " " + rezultatm);
            Console.WriteLine(prvi + " " + "/" + " " + drugi + " " + "=" + " " + rezultatd);
            Console.WriteLine(prvi + " " + "ostatak" + " " + drugi + " " + "=" + " " + rezultatostatak);
            Console.ReadKey();
        }
    }
}
