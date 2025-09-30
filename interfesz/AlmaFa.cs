using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfesz
{
    internal class AlmaFa:fa
    {
        public string Név {  get; set; }
        public void kivag()
        {
            Console.WriteLine("Timbeeerrrrrr!!");
        }
        public string terem()
        {
            return "gyümölcsözik";
        }
    }
}
    
