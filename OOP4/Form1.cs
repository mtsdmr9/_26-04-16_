using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4
{

    /*
     
        Private: Bir class içerisindeki bir metodun yada bir değişkenin private olarak tanımlanması, ek olarak herhangi bir aç modifiers da belirtilmesi, o methodun yada değişkenin sadece o class içerisinden ulaşılabilmesi anlamına gelir. İlgili sınıftan türemiş olan diğer sınıflardan bile erişim sağlanamaz.
     
        Public: Her yerden erişim sağlanması için bu a.modifiers kullanılır. Herhangi bir kısıtlama söz konusu değildir. Başka solution dan da ulaşılabilir.

        Protected: Bu şekilde tanımlanmış olan değişken veya metotlara aynı sınıfta ulaşılabileceği gibi o sınıftan kalıtım alan o sınıftan türemiş olan sınıflardan da ulaşılabilir. Arı: Hayvan gibi yapılarda. sağdaki kalıtım verir. yani hayvan kategorisinde olan arıya ulaşılabilir. 

        Internal:Solution ın içindeki sadece aynı projede üzerinden ulaşılabilir. Solution içerisindeki diğer projelerden internal tanımlanmış bir metot veya değişkene erişim söz konusu değildir.

        Protected Internal: aynı solutionda birden fazla projeye kalıtım veren yapılar için söz konusudur.

        Default(Varsayılan olarak gelen değerler): Class ve Interface önünde Internal, metot ve değişkenlerde private gelir.


      
       */
   public class Ari
    {
        private void Metot1() { }
        public void MetotPublic() { }
        protected void MetotProtected() { }
        internal void MetotInternal() { }
    }
}
