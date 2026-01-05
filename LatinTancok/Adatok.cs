using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinTancok
{
    internal class Adatok
    {
        public string tancTipus;
        public string lany;
        public string fiu;
        public Adatok(string tanc, string tancos1, string tancos2)
        {
            tancTipus = tanc;
            lany = tancos1;
            fiu = tancos2;
        }
    }
}
