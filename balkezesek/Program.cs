using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace balkezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ketbalkezes> lista = new List<ketbalkezes>();
            foreach (var i in File.ReadAllLines("balkezesek.csv").Skip(1))
            {
                lista.Add(new ketbalkezes(i));
            }

            Console.WriteLine("3. feladat: " + lista.Count);
            Console.WriteLine("4. feladat: ");
            foreach (var i in lista)
            {
                if (i.utolso.Date.Year == 1999 && i.utolso.Date.Month == 10)
                {
                    Console.WriteLine("\t{0} , {1:0.0} cm", i.nev, i.magassag * 2.54);
                }
            }
            Console.WriteLine("5. feladat");
            bool kerdes = true;
            while (kerdes == true)
            {
                Console.Write("Kérek egy 1990 és 1999 közötti évszámot!: ");
                int valami = int.Parse(Console.ReadLine());
                if (valami <= 1990 || valami >= 1999)
                {
                    Console.Write("Hibás adat!");
                }
                else
                {
                    Console.WriteLine("köszönjük");
                    kerdes = false;
                }
            }

        }
    }
}
