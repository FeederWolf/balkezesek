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

            foreach (var i in lista)
            {
                if (i.utolso.Date.Year == 1999 && i.utolso.Date.Month == 10)
                {
                    Console.WriteLine("{0} , {1:0.00} cm", i.nev, i.magassag * 2.54);
                }
            }


        }
    }
}
