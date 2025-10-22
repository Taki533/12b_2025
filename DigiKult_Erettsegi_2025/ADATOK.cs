using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKult_Erettsegi_2025
{
    internal class ADATOK
    {
        public int km;
        public string jelzes;
        public ADATOK(string sor) 
        {
            string[] s = sor.Split(" ");
            km = int.Parse(s[0]);
            jelzes = s[1];
        }
        public ADATOK(int ut , string jelzes) 
        {
            km = ut;
            this.jelzes = jelzes;
        }
        public bool Telepulese()
        {
            if (jelzes.Length >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
    }
}
