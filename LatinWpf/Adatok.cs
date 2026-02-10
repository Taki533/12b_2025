using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinWpf
{
    internal class Adatok
    {
        public string TancNeve { get; set; }
        public string LanyNeve { get; set; }
        public string FiuNeve { get; set; }

        public Adatok(string tanc, string lany, string fiu)
        {
            TancNeve = tanc;
            LanyNeve = lany;
            FiuNeve = fiu;
        }
    }
}
