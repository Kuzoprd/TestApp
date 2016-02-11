using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool mocmoc = false;
            Console.WriteLine("Zadej číslo, které si přeješ umocnit:");
            float a;
            int b;
            bool fa = float.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Kolikátou mocninu chceš zpočítat?");
            bool fb = int.TryParse(Console.ReadLine(), out b);
            float dm = a * a;
            float tm = dm * a;
            float cm = tm * a;
            float pm = cm * a;
            float sm = pm * a;
            float sedm = sm * a;
            float om = sedm * a;
            double vys = 0;
            if ((fa == true) && (fb == true))
            {
                if (b == 2) { vys = dm; }
                else if (b == 3) { vys = tm; }
                else if (b == 4) { vys = cm; }
                else if (b == 5) { vys = pm; }
                else if (b == 6) { vys = sm; }
                else if (b == 7) { vys = sedm; }
                else if (b == 8) { vys = om; }
                else
                {
                    Console.WriteLine("Neumím udělat tento typ mocniny! Zkus čísla 2 až 8.");
                    mocmoc = true;
                }
                if (mocmoc == false) { Console.WriteLine("Výsledek je " + vys + "."); }
            }
            else { Console.WriteLine("Do zadání nemůžeš psát text! Restartuj aplikaci."); }
            Console.ReadKey();
        }
    }
}
