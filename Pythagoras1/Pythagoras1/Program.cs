using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagoras1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sCathetusA, sCathetusB;
            double dCathetusA, dCathetusB, dHypotenuse;
            Console.WriteLine("Kathete a:");
            sCathetusA = Console.ReadLine();
            if (!Double.TryParse(sCathetusA, out dCathetusA))
            {
                if (sCathetusA != "x" || sCathetusA != "e")
                {
                    Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q) ;
                }
                return;
            }
            dCathetusA = Double.Parse(sCathetusA);
            Console.WriteLine("Kathete b:");
            sCathetusB = Console.ReadLine();
            if (!Double.TryParse(sCathetusB, out dCathetusB))
            {
                if (sCathetusB != "x" || sCathetusB != "e")
                {
                    Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q) ;
                }
                return;
            }
            dCathetusB = Double.Parse(sCathetusB);
            dHypotenuse = Math.Sqrt(Math.Pow(dCathetusA, 2) * (Math.Pow(dCathetusB, 2)));
            Console.WriteLine("Hypotenuse c: {0}cm", dHypotenuse);
            Console.WriteLine("Umfang: {0}cm", dCathetusA + dCathetusB + dHypotenuse);
            Console.WriteLine("Flächeninhalt: {0}cm²", (dCathetusA * dCathetusB) / 2);
            Console.Read();
        }
    }
}
