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
        public bool Varosban;
        public ADATOK(string sor)
        {
            string[] s = sor.Split(" ");
            km = int.Parse(s[0]);
            jelzes = s[1];
        }
        public ADATOK(int ut, string jelzes)
        {
            km = ut;
            this.jelzes = jelzes;
        }
        public bool Telepulese()
        {
            return jelzes.Length >= 4;
        }
        public int sebessegHatar()
        {
            try
            {
                int sebbeseg = int.Parse (jelzes);
                return sebbeseg;
            }
            catch (Exception e)
            {
                if (Telepulese()) 
                {
                    return 50;
                    
                }
                else if( jelzes=="]")
                {
                    return 90;
                }
                else if (jelzes == "#")
                {
                    if (Varosban)
                    {
                        return 50;
                    }
                    else
                    {
                        return 90;
                    }
                        
                }
                else if (jelzes == "%")
                    if (Varosban)
                    {
                        return 50;
                    }
                    else
                    {
                        return 90;
                    }
                else
                {
                    return 0;
                }
            }
        }
    }
}
