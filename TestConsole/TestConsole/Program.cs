using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Jednoduchá kalkulačka";
            string b = "První číslo:";
            string c = "Druhé číslo:";
            string d = "Metoda: (Součet-1; Rozdíl-2; Součin-3; Podíl-4)";
            string e = "Výsledek: ";
            string f = "Díky za využití této zázračné kalkulačky. Budu pokračovat ve vývoji... xD";
            Console.WriteLine(a);
            Console.WriteLine(b);
            float pc = float.Parse(Console.ReadLine());
            Console.WriteLine(c);
            float dc = float.Parse(Console.ReadLine());
            Console.WriteLine(d);
            float met = float.Parse(Console.ReadLine());
            if (met == 1)
            {
                Console.WriteLine(e+(pc+dc));
            }
            else if (met == 2)
            {
                Console.WriteLine(e+(pc-dc));
            }
            else if (met == 3)
            {
                Console.WriteLine(e+(pc*dc));
            }
            else if (met == 4)
            {
                Console.WriteLine(e+(pc/dc));
            }
            else { Console.WriteLine("ERROR!"); }
            Console.WriteLine();
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
