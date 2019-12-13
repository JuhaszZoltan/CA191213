using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191213
{
    class Program
    {
        static int pontszam = 0;
        static void Main()
        {
            FeladatKiiras();
            Teszt();
            Eredmeny();
        }
        static void FeladatKiiras()
        {
            Console.WriteLine("Szókincs\n");

            var sr = new StreamReader("..\\..\\feladat.txt", Encoding.UTF8);
            string feladatSzovege = sr.ReadLine();
            Console.WriteLine(feladatSzovege);
            sr.Close();

            Console.WriteLine("\n");
            Console.WriteLine("Kezdéshez nyomja meg az ENTERT...");

            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        static void Teszt()
        {
            var srk = new StreamReader("..\\..\\teszt.txt", Encoding.UTF8);
            var srm = new StreamReader("..\\..\\megoldas.txt", Encoding.UTF8);

            while (!srk.EndOfStream)
            {
                Console.Clear();

                Console.WriteLine(srk.ReadLine());
                for (int i = 0; i < 3; i++)
                    Console.WriteLine($"   {srk.ReadLine()}");

                Console.Write("\nGépelje be a helyes válasz betűjelét: ");
                string valasz = Console.ReadLine();

                if(srm.ReadLine() == valasz.ToUpper())
                {
                    pontszam++;
                    Console.WriteLine("\n   Jó válasz!");
                }
                else Console.WriteLine("\n   Rossz válasz!");

                System.Threading.Thread.Sleep(2000);
            }
        }

        static void Eredmeny()
        {
            Console.Clear();
            Console.WriteLine("A teszt végetért!");
            Console.WriteLine($"{pontszam} pontot értél el a 15-ból");
            Console.ReadKey();
        }
    }
}
