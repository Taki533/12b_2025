using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverride
{
    internal class Szam
    {
        public int szam;
        public Szam( int szam) 
        {
            this.szam = szam;
        }
        public static  Szam operator +(Szam szam1,Szam szam2)
        {
            return  new Szam(szam1.szam+szam2.szam);
        }
        public static Szam operator +(Szam szam1, int szam2)
        {
            return new Szam(szam1.szam + szam2);
        }
        public static int operator +(int szam1, Szam szam2)
        {
            return szam1 + szam2.szam;
        }
        public static Szam operator ++(Szam szam)
        {
            return new Szam(szam.szam+1);
        }
        public static Szam operator +(Szam szam1,double szam2)
        {
            return new Szam(szam1.szam + Convert.ToInt32(Math.Round(szam2)));
        }
        public override string ToString()
        {
            return "A szám értéke: "+szam;
        }
    }
}
