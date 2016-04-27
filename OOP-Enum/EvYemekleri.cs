using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Enum
{
    class EvYemekleri: Yemek
    {
       public enum EtSunumTipleri
        {
            Izgara,
            Haslama,
            Kavurma,
            Sote
        }
        public EtSunumTipleri EtSunum { get; set; }
        public int Porsiyon { get; set; }
    }
}
