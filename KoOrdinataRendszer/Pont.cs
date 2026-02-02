using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoOrdinataRendszer
{
    internal class Pont
    {
        public int x;
        public int y;
        public Pont(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Pont operator +(Pont a, Pont b)
        {
            return  new Pont(a.x + b.x , a.y + b.y);
        }
        public static Pont operator -(Pont a, Pont b)
        {
            return  new Pont(a.x - b.x , a.y - b.y);
        }
        public static bool operator ==(Pont a, Pont b)
        {
            return  a.x==b.x && a.y == b.y;
        }
        public static bool operator !=(Pont a, Pont b)
        {
            return  a.x!=b.x || a.y != b.y;
        }
        public static bool operator >=(Pont a, Pont b)
        {
            return  a.Tavolsag() >= b.Tavolsag();
        }
        public static bool operator <=(Pont a, Pont b)
        {
            return a.Tavolsag() <= b.Tavolsag();
        }
        public static Pont operator +(Pont a, int b)
        {
            return new Pont(a.x + b, a.y + b);
        }
        public static Pont operator -(Pont a, int b)
        {
            return a + b*-1;
        }

        public override string ToString()
        {
            return $"x:{x} y:{y}";
        }
        public double Tavolsag()
        {
            return Math.Sqrt ( Math.Pow(x,2) + Math.Pow(y,2));
        }
    }
}
