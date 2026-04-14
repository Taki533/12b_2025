using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Feluliras
{
    internal class Szoveg
    {
        public string szoveg;
        public Szoveg(string txt)
        {
            this.szoveg = txt;
        }

        public static Szoveg operator + (Szoveg szoveg1, Szoveg szoveg2)
        {
            return  new Szoveg(szoveg1.szoveg + "\n"+ szoveg2.szoveg);
        }
        public static Szoveg operator + (Szoveg szoveg1, string szoveg2)
        {
            return  new Szoveg(szoveg1.szoveg + "\n"+ szoveg2);
        }
        public static string operator + (string szoveg1, Szoveg szoveg2)
        {
            return  szoveg1 + "\n"+ szoveg2.szoveg;
        }
        public static Szoveg operator - (Szoveg szoveg1, string szoveg2)
        {
            Console.WriteLine(szoveg1.szoveg);
            string atmeneti = szoveg1.szoveg;
            for (int i = 0; i< szoveg2.Length; i++)
            {
                if (atmeneti.Contains(szoveg2[i]))
                {
                   atmeneti = atmeneti.Replace(szoveg2[i].ToString(), "");
                }
            }
            
            return  new Szoveg(atmeneti);
        }
        public static bool operator <(Szoveg szoveg1, Szoveg szoveg2)
        {
            return szoveg1.szoveg.Length<szoveg2.szoveg.Length ;
        }
        public static bool operator >(Szoveg szoveg1, Szoveg szoveg2)
        {
            return szoveg1.szoveg.Length < szoveg2.szoveg.Length;
        }
        public static bool operator ==(Szoveg szoveg1, Szoveg szoveg2)
        {
            return szoveg1.szoveg.Length == szoveg2.szoveg.Length;
        }
        public static bool operator !=(Szoveg szoveg1, Szoveg szoveg2)
        {
            return szoveg1.szoveg.Length != szoveg2.szoveg.Length;
        }


    }
}
