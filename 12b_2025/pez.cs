using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12b_2025
{
    internal class pez
    {
        public string szin;
        public string iz;
        public string csomagolas;
        public string csomagolasDizajn;
        public int meret;
        public int darabszam;
        public pez(string szin, string iz, string csomagolas, string csomagolasDizajn, int meret, int darbszam)
        {
            this.szin = szin;
            this.iz = iz;
            this.csomagolas = csomagolas;
            this.csomagolasDizajn = csomagolasDizajn;
            this.meret = meret;
            this.darabszam = darbszam;
        }
        public void Megmergez()
        {
            Random rand = new Random();
            int mergez = (int)Math.Floor(rand.NextDouble());
            if (mergez == 0)
            {
                Console.WriteLine("mergzo volt a pez meghaltál!");
            }
            else
            {
                Console.WriteLine("NEm volt mergezo a pez tul elted!");
            }
        }
    }
}
