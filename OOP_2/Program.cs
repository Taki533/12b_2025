using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Farmer n = new Farmer();
            n.nyulik();
            n.meret = "56";
            n.tipus = "Livájsz";
            n.anyag = "farmer";
            Console.WriteLine(n);
        }
    }
}
