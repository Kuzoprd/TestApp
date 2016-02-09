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
            Console.WriteLine("Zadej číslo, které si přeješ umocnit:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Kolikátou mocninu chceš zpočítat?");
            int b = int.Parse(Console.ReadLine());
            float dm = a * a;
            float tm = dm * a;
            float cm = tm * a;
            float pm = cm * a;
            float sm = pm * a;
            float sedm = sm * a;
            float om = sedm * a;
            float vys = 0;
            if (b == 2) { vys = dm; }
            else if (b == 3) { vys = tm; }
            else if (b == 4) { vys = cm; }
            else if (b == 5) { vys = pm; }
            else if (b == 6) { vys = sm; }
            else if (b == 7) { vys = sedm; }
            else if (b == 8) { vys = om; }
            else { Console.WriteLine("Neumím udělat tento typ mocniny! Zkus čísla 2 až 8."); }
            Console.WriteLine();
            Console.WriteLine("Výsledek je " + vys + ".");
            Console.ReadKey();
        }
    }
}
