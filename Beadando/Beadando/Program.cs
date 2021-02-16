using System;

namespace Beadando
{
    internal static class Program
    {
        // 1. Készíts programot, ami bekér egy n számot és kiírja a természetes számokat n-ig!
        private static void KiirN()
        {
            Console.Write("n: ");
            var n = Convert.ToInt32(Console.ReadLine());
            for (var i = 1; i <= n; i++)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        // 2. Készíts programot, ami bekéri az aktuális évet és megállapítja, hogy szökőév-e?
        private static bool Szokoev(int ev)
        {
            return DateTime.IsLeapYear(ev);
        }

        // 3. Készíts programot, ami bekéri az aktuális hónap és nap sorszámát és kiírja, hogy az év hányadik napjánál járunk! (kell hozzá az előző feladat is, miért?)
        private static int EvHanyadikNapja(int ev)
        {
            Console.Write("Honap: ");
            var honap = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nap: ");
            var nap = Convert.ToInt32(Console.ReadLine());
            var datum = new DateTime(ev, honap, nap);

            return datum.DayOfYear;
            // szokoev() fuggveny azert kellhet, hogy szokoev eseten a feb. 29. nap miatt +1-gyel novelje az nap sorszamat
        }

        // 4. Bővítsd az előző programot, hogy induláskor menüből választhasson: az aktuális mai dátumra kíváncsi a felhasználó, vagy ő akar megadni egyet!
        private static void EvHanyadikNapjaOpcio()
        {
            var aktualis = false;
            Console.Write("Aktualis datum hasznalata? (i/n): ");
            var valasz = Console.ReadLine();
            if (valasz != null) aktualis = valasz.Equals("i");

            DateTime datum;
            if (aktualis)
            {
                datum = DateTime.Now;
            }
            else
            {
                Console.Write("Ev: ");
                var ev = Convert.ToInt32(Console.ReadLine());
                Console.Write("Honap: ");
                var honap = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nap: ");
                var nap = Convert.ToInt32(Console.ReadLine());
                datum = new DateTime(ev, honap, nap);
            }

            Console.WriteLine(datum.Year + "." + datum.Month + "." + datum.Day + ". datum az ev " + datum.DayOfYear +
                              ". napja.");
            //return datum.DayOfYear; // ha a metodus void helyett int
        }

        public static void Main(string[] args)
        {
            KiirN();
            Console.Write("Ev: ");
            var ev = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ev + " szokoev : " + Szokoev(ev));
            Console.WriteLine("Ma az ev " + EvHanyadikNapja(ev) + ". napja van.");
            EvHanyadikNapjaOpcio();
        }
    }
}