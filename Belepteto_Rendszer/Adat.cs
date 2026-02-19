using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belepteto_Rendszer
{
    internal class Adat
    {
        public string kod;
        public string ido;
        public int esemenyKod;
        public Adat(string kod,string ido,int esemeny) {
            this.kod = kod;
            this.ido = ido;
            this.esemenyKod = esemeny;
        }

        public Adat(string sor) {
            string[] adatok = sor.Split(' ');
            this.kod = adatok[0];
            this.ido = adatok[1];
            this.esemenyKod = int.Parse(adatok[2]);
        }

    }
}
