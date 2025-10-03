using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    abstract internal class nadrag:IrUHA
    {
       
        public string tipus { get; set; }
        public  string anyag { get; set; }
        public string meret { get; set; }
        abstract public void nyulik();

        public override string ToString()
        {
            return "A Nadrag Anyaga: "+anyag+" A Nadrag mérete: "+anyag+" A nadrag tipusa: "+tipus;
        }

    }
}
