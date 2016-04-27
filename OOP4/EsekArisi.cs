using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    /*

        Kalıtım Verme İşlemi: İki nokta ile yapılır.
        EsekArisi bir arıdır. EsekArisi as Ari
        classtan aynı anda kalıtım alamaz.(Inheritance)
     
         */
    class EsekArisi: Ari //kalıtımı aldık. Inheritance
    {
        public EsekArisi()
        {
            Ari aricik = new Ari(); //yeni bir arı tanımladık ve onun içindekileri aricik değişkenine aktardık.
            //aricik.MetotInternal
            //aricik.MetotPublic
            //this.MetotProtected
        }
    }
}
