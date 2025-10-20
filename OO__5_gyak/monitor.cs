using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO__5_gyak
{
    internal class monitor
    {
        public string felbontas;
        public double atlo;
        public monitor(string felbontas)
        {
            this.felbontas = felbontas;
        }
        public monitor(string felbontas,double kepernyoAtlo)
        {
            this.felbontas= felbontas;
            atlo = kepernyoAtlo;
        }
    }
}
