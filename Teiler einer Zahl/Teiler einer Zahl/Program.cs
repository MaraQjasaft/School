using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teiler_einer_Zahl
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl, ergebnis, teiler_anzahl = 1, zaehler = 1;
            string antwort;

            do
            {
                Console.WriteLine("Ausgabe der Teiler einer Zahl");
                Console.WriteLine("--------------------------");
                Console.WriteLine();
                Console.Write("Bitte eine ganze Zahl > 0 eigeben: ");
                zahl = Convert.ToInt32(Console.ReadLine());



                for (int i = 1; i < zahl + 1; i++)
                {

                    if (zahl % i == 0)
                    {
                        ergebnis = zahl / i;
                        Console.WriteLine("Der " + teiler_anzahl + ". Teiler ist: " + ergebnis);

                        teiler_anzahl++;

                    }

                }

                if (teiler_anzahl == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Die eingegebene Zahl ist eine Primzahl und nur durch 1 und sich selbst teilbar.");
                    Console.WriteLine();
                }

                teiler_anzahl = 1;
                Console.Write("Soll das Programm erneut ausgeführt werden? (j)");
                antwort = Console.ReadLine();
                Console.WriteLine();
                
                
            }

            while (antwort == "j");

            Console.ReadKey();
        }
    }
}
