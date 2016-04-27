using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ctor
{
    public class Dukkan
    {
        public string Adres { get; set; }
        public sbyte OdaSayisi { get; set; }
        public Decimal Ucret { get; set; }
        public bool KiralikMi { get; set; }

        // Constructor: Nesnenin doğum anına verilen addır. Yapıcı metot adı da verilir.
        //Siz class içerisinde ctor tanımlaması yapmasanız bile her classta varsayılan olarak bir tane ctor gelir.(parametresizdir.)
        //Ctor içerisinde illaki değer ataması yapmak zorunda değiliz.
        //tanımlaması:
        public Dukkan() { } //Form loada new Dukkan() yazdığımızda bu metot gelir.
        //Ctor parametre ataması yapalım.ctor overload
        public Dukkan(string AdresNe,decimal UcretNe)
        {
            Adres = AdresNe; //buradan gelen değeri property ye aktarırız.
            Ucret = UcretNe; //eğer formload da new dukkan("kadıköy",5); dersek bunu alır vermezsek üstteki çalışır.
        }
    }
}
