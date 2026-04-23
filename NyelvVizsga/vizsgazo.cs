using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyelvVizsga
{
    internal class vizsga
    {
        public string nyelv;
        public Dictionary<string, int> evek;

        public vizsga(string nyelv, Dictionary<string, int> evek)
        {
            this.nyelv = nyelv;
            this.evek = evek;
        }
        public vizsga(string sor)
        {

            string[] adatok = sor.Split(';');
            this.nyelv = adatok[0];
            this.evek = new Dictionary<string, int>();

            for (int i = 1; i < adatok.Length; i++)
            {
                evek[(i + 2008).ToString()] = int.Parse(adatok[i]);
            }
        }

    }
}
