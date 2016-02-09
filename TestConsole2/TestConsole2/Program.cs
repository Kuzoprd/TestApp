using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Čauves, jak se jmenuješ týpku?");
            string a = Console.ReadLine();
            Console.WriteLine("Jakej jsi, týpku?");
            string b = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(a + " je " + b + ".");
            Console.ReadKey();
        }
    }
}
