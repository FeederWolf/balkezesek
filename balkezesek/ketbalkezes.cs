using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balkezesek
{
    class ketbalkezes
    {
        /*név;első;utolsó;súly;magasság*/

        public string nev { get; set; }
        public DateTime elso { get; set; }
        public DateTime utolso { get; set; }
        public int suly { get; set; }
        public int magassag { get; set; }

        public ketbalkezes(string sor)
        {
            string[] s = sor.Split(';');

            nev = s[0];
            elso = DateTime.Parse(s[1]);
            utolso = DateTime.Parse(s[2]);
            suly = int.Parse(s[3]);
            magassag = int.Parse(s[4]);
        }

    }
}
