using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sipalya
{
    internal class palya
    {
        public int ho;
        public palya(int ho)
        {
            this.ho = ho;
        }

        public static palya operator +(palya p1, palya p2)
        {
            return  new palya(p1.ho + p2.ho);
        }
        public static palya operator +(palya p1, int vastagsag)
        {
            return  new palya(p1.ho + vastagsag);
        }
        public static int operator +(int vastagsag, palya p1)
        {
            return vastagsag + p1.ho;
        }
        public static palya operator -(palya p1, palya p2)
        {
            return new palya(p1.ho - p2.ho);
        }
        public static palya operator -(palya p1, int p2)
        {
            return new palya(p1.ho - p2);
        }
        public static palya operator -(int p1, palya p2)
        {
            return new palya(p1 - p2.ho);
        }
        public static bool operator >(palya p1, palya p2)
        {
            return p1.ho>p2.ho;
        }
        public static bool operator <(palya p1, palya p2)
        {
            return p1.ho<p2.ho;
        }
        public static bool operator ==(palya p1, palya p2)
        {
            return p1.ho==p2.ho;
        }
        public static bool operator !=(palya p1, palya p2)
        {
            return p1.ho!=p2.ho;
        }
        public static bool operator >=(palya p1, palya p2)
        {
            return p1.ho>=p2.ho;
        }
        public static bool operator <=(palya p1, palya p2)
        {
            return p1.ho<=p2.ho;
        }




    }
}
