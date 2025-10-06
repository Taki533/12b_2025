using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class kampanyFilm:video
    {
        public override void show()
        {
            Console.WriteLine("a lejatszas elindult");
        }

        public override string ToString()
        {
            return "a film nagyon epikus lett a viktor setal allandoan";
        }
    }
}
