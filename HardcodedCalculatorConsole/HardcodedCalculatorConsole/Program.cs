using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardcodedCalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Proměnné
            string err1 = "Chyba při zadávání čísla! Zkus to znovu.";
            string err2 = "Chyba při zadávání čísla metody! Zkus to znovu.";
            string err3 = "Chyba při zadávání hodnoty! Zkus to znovu.";

            float pc;
            float dc;
            double vys = 0;
                // Vždy před *while* vyvrátit nebo potvrdit, ve *while* s tím něco provést
            bool fmet; // Funguje metoda (chybová odpověď)
            bool fpok; // Funguje pokračování (chybová odpověď)
            bool pok = true; // Pokračování
            Console.WriteLine("Hardcoded Calculator v1.0");
            while (pok)
            {
                // Načítání čísel
                Console.WriteLine("============================");
                Console.WriteLine("Napiš první číslo:");
                while (!float.TryParse(Console.ReadLine(), out pc)) // Zadání prvního čísla
                    Console.WriteLine(err1);
                Console.WriteLine("Napiš druhé číslo:");
                while (!float.TryParse(Console.ReadLine(), out dc)) // Zadání druhého čísla
                    Console.WriteLine(err1);
                Console.WriteLine("Metoda: (1-Součet, 2-Rozdíl, 3-Součin, 4-Podíl, 5-Mocnina)");

                // Výpočty + platná metoda
                fmet = false;
                while (!fmet)
                {
                    fmet = true;
                    switch (Console.ReadKey().KeyChar) // Zadání metody
                    {
                        case '1':
                            vys = pc + dc;
                            break;
                        case '2':
                            vys = pc - dc;
                            break;
                        case '3':
                            vys = pc * dc;
                            break;
                        case '4':
                            vys = pc / dc;
                            break;
                        case '5':
                            vys = pc;
                            for (float i = 0; i < (dc - 1); i++)
                                vys = vys * pc;
                            break;
                        default:
                            fmet = false; // Špatná metoda
                            break;
                    }
                    Console.WriteLine();
                if (fmet)
                    Console.WriteLine("Výsledek je: {0}", vys);
                else
                    Console.WriteLine(err2);
                }
                
                // Pokračování
                Console.WriteLine("Přejete si pokračovat v práci? [a/n]");
                fpok = false;
                while (!fpok)
                {
                    switch (Console.ReadKey().KeyChar.ToString().ToLower())
                    {
                        case "a": // Chceme pokračovat
                            pok = true;
                            fpok = true;
                            break;
                        case "n": // Nechceme pokračovat
                            pok = false;
                            fpok = true;
                            break;
                        default:
                            Console.WriteLine(err3);
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
