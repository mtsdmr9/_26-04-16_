using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Enum
{
    public class Markalar: Ayakkabi
    {
        public string Markasi { get; set; }
        public enum MarkaAdi
        {
            Nike,
            Adidas,
            Puma,
            Timberland,
            Kinetix
            
        } 
    }
}
