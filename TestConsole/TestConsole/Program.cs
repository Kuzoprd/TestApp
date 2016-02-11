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
            string d = "Metoda: (Součet-1; Rozdíl-2; Součin-3; Podíl-4; Mocnina-5)";
            string e = "Výsledek: ";
            string f = "Do zadání nemůžeš psát text! Restartuj aplikaci.";
            string g = "Přejete si pokračovat ve výpočtech? (ano-pokračovat)";
            string h = "Chyba! Napsal jsi neexistující metodu.";
            float pc;
            float dc;
            byte met;
            Console.WriteLine(a);
            char op = 'a';
            while (op == 'a')
            {

                op = 'n'; // Aby se to na konci zeptalo
                Console.WriteLine(b);
                bool fpc = float.TryParse(Console.ReadLine(), out pc);
                Console.WriteLine(c);
                bool fdc = float.TryParse(Console.ReadLine(), out dc);
                Console.WriteLine(d);
                bool fmet = byte.TryParse(Console.ReadLine(), out met);
                float sce = pc + dc; // Proměnná - výpočet sčítání
                float rdi = pc - dc; // Proměnná - výpočet odčítání
                float sci = pc * dc; // Proměnná - výpočet násobení
                float pdi = pc / dc; // Proměnná - výpočet dělení
                double moc = pc;
                for (int i = 0; i < (dc - 1); i++)
                    moc = moc * pc; // Opakování - výpočet mocniny
                if ((fpc == true) && (fdc == true) && (fmet == true))
                {
                    if (met == 1) { Console.WriteLine(e + sce); }
                    else if (met == 2) { Console.WriteLine(e + rdi); }
                    else if (met == 3) { Console.WriteLine(e + sci); }
                    else if (met == 4) { Console.WriteLine(e + pdi); }
                    else if (met == 5) { Console.WriteLine(e + moc); }
                    else { Console.WriteLine(h); op = 'a'; } // Chyba + automat. opak.
                }
                else { Console.WriteLine(f); op = 'a'; } // Chyba + automat. opak.
                if (op == 'n')
                {
                    Console.WriteLine(g);
                    op = (char)Console.Read(); // Pokračování ve výpočtech
                }      // ^^^^ !!! S CHAREM TO NEBĚŽÍ SPRÁVNĚ... PODÍVEJ SE TOMU NA ZOUBEK... !!!
            }
            Console.ReadKey();
        }
    }
}
