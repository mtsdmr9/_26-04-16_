using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_App2
{
    class Sehirler
    {
        //Her sehrin ... vardır.
        public string Adi { get; set; }

        public override string ToString()
        {
            return this.Adi;
        }
    }
}
