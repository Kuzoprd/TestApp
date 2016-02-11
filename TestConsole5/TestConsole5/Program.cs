using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Mocnítko");
            Console.WriteLine("Zadejte mocněné číslo:");
            bool fa = int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Zadejte mocnitel:");
            bool fb = int.TryParse(Console.ReadLine(), out b);
            long vys = a;
            for (int i = 0; i < (b - 1); i++)
                vys = vys * a;
            if ((fa == true) && (fb == true))
                Console.WriteLine("Výsledek je {0}.", vys);
            else
                Console.WriteLine("Neumím pracovat s textem!");
            Console.ReadKey();
        }
    }
}
