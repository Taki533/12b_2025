using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace godrok
{
    internal class Godor
    {
        public List<Melyseg> melysegek;

        public Godor()
        {
            melysegek = new List<Melyseg>();
        }

        public void Add(Melyseg melyseg)
        {
            melysegek.Add(melyseg);
        }
        public bool Contains(int meter)
        {
            return GetFirst().Meter <= meter && GetLast().Meter >= meter;
        }
        public Melyseg GetFirst() { return melysegek.First(); }
        public Melyseg GetLast() { return melysegek.Last(); }

        public bool isMonotonous()
        {
            var eredmeny = melysegek.Skip(1).Select((melyseg, i) => { melyseg.Meter >= melysegek[i].Meter });
        }
    }
}
