using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    abstract internal class video:IMedia
    {
        protected video() 
        {

        }
        public string tipus
        {
            get
                {
                    return "video";
                }
        }
        abstract public void show();
    }
}
