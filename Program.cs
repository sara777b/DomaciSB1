using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciSB1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double dijagonala;
            Console.Write("Unesite stranicu a: ");

            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Unesite stranicu b: ");
            
            b = Convert.ToDouble(Console.ReadLine());

            dijagonala = Math.Sqrt(a*a + b * b);

            Console.WriteLine("Dijagonala pravougaonika je" + " " + dijagonala);
            Console.ReadKey();
        }
    }
}
