using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.14159265359F;
            float r;
            Console.WriteLine("Napiš poloměr kružnice/kruhu: (v cm)");
            bool f = float.TryParse(Console.ReadLine(), out r);
            float obv = 2 * pi * r;
            double obs = pi * (r * r);
            Console.WriteLine();
            if (f == !false)
            {
                Console.WriteLine("Obvod kružnice/kruhu je: " + obv + " cm.");
                Console.WriteLine("Obsah kruhu je: " + obs + " cm2.");
            }
            else { Console.WriteLine("Kalkulačka neumí počítat s textem! Restartujte aplikaci."); }
            Console.ReadKey();
        }
    }
}
