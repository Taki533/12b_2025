using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_operatorok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Szamok a = new Szamok(new int[] { 1, 2, 3, 4, 5 });
            Szamok b = new Szamok(new int[] { 6, 7, 8, 9, 10,12,13 });

            Console.WriteLine(a * b);
        }

    }
}
