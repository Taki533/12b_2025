using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Jürgen
{
    internal class Penztarca
    {
        public int eur;
        public Penztarca(int eur)
        { this.eur = eur; }
        public static int operator -(Penztarca jurgen, int Hansi)
        {
            
            return jurgen.eur -Hansi;
        }
        public static Penztarca operator -(Penztarca jurgen,Penztarca FrauMaria)
        {
                return new Penztarca(jurgen.eur-FrauMaria.eur);
        }

        public static bool operator <(Penztarca Jurgen,Penztarca FrauMaria)
        {
            return Jurgen.eur < FrauMaria.eur;
        }
        public static bool operator >(Penztarca Jurgen,Penztarca FrauMaria)
        {
            return Jurgen.eur > FrauMaria.eur; 
        }
        public override string ToString()
        {
            return eur+" euróm van";
        }
        public static Penztarca operator +(Penztarca Jurgen,Penztarca Komuvesvallalat)
        {
            return new Penztarca(Jurgen.eur + Komuvesvallalat.eur);
        }
        public static Penztarca operator +(Penztarca Jurgen,int Komuvesvallalat)
        {
            return new Penztarca(Jurgen.eur + Komuvesvallalat);
        }
        public static int operator +(int Jurgen,Penztarca idk)
        {
            return Jurgen + idk.eur;
        }


    }
}
