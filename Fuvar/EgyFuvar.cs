using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    internal class EgyFuvar
    {
        public int azonosito;
        public string indulas;
        public int idotartam;
        public double tavolsag;
        public double viteldij;
        public double borravalo;
        public string fizetesModja;
        
        public EgyFuvar(string sor)
        {
            string[] adatok = sor.Split(';');
            this.azonosito = int.Parse(adatok[0]);
            this.indulas = adatok[1];
            this.idotartam = int.Parse(adatok[2]);
            this.tavolsag = double.Parse(adatok[3]);
            this.viteldij = double.Parse(adatok[4]);
            this.borravalo = double.Parse(adatok[5]);
            this.fizetesModja = adatok[6];
        }
        public EgyFuvar(int azonosito, string indulas, int idotartam, double tavolsag, double viteldij, double borravalo, string fizetesModja)
        {
            this.azonosito = azonosito;
            this.indulas = indulas;
            this.idotartam = idotartam;
            this.tavolsag = tavolsag;
            this.viteldij = viteldij;
            this.borravalo = borravalo;
            this.fizetesModja = fizetesModja;
        }

    }
}
