using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestConsole6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome. Please enter your command: ");
            bool activated = false;
            bool exit = false;
            while (!exit)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case 'x':
                        {
                            Console.WriteLine("\r You pressed x...");
                            break;
                        }
                    case 'y':
                        {
                            Console.WriteLine("\r You pressed y..");
                            break;
                        }
                    case 'd':
                        {
                            if (activated != true)
                            {
                                Console.WriteLine("\r Please activate first!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\r Active..");
                                break;
                            }
                        }
                    case 'a':
                        {
                            if (activated != true)
                            {
                                activated = true;
                                Console.WriteLine("\r Activating..");
                                break;
                            }
                            else
                            {
                                activated = false;
                                Console.WriteLine("\r Deactivating..");
                                break;
                            }
                        }
                    case 'q':
                        exit = true;
                        Console.WriteLine("\r Exiting..");
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.WriteLine("\r Unknown Command.");
                        break;
                }
            }
        }
    }
}
