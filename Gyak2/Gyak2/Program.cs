using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 32;
            double y = 32;

            Console.WriteLine("x.ToString(): " + x.ToString());
            Console.WriteLine("x.Equals(y): " + x.Equals(y));
            Console.WriteLine("y.Equals(x): " + y.Equals(x));
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // int z = null; // igy nem
            Nullable<int> z = null;
            // int ? z = null; // igy is lehet
            if (z.HasValue)
            {
                Console.WriteLine("Van erteke: " + z.Value);
            } else
            {
                Console.WriteLine("Nincs erteke.");
            }
        }
    }
}
