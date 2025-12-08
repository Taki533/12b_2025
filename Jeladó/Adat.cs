using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeladó
{
    internal class Adat
    {
        public int h;
        public int m;
        public int s;
        public int x;
        public int y;

        void eltarol(int h, int m, int s, int x, int y)
        {
            this.h = h;
            this.m = m;
            this.s = s;
            this.x = x;
            this.y = y;
        }
        public Adat(int h, int m, int s, int x, int y)
        {
            eltarol(h, m, s, x, y);
        }
        public Adat(string sor)
        {
            string[] vag = sor.Split(" ");
            eltarol(int.Parse(vag[0]), int.Parse(vag[1]),int.Parse(vag[2]),int.Parse(vag[3]),int.Parse(vag[4]));
            
        }
    }
}
