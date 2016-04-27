using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Static
{
    //Static anahtar kelimesi:

        /*
        bu aahtarı üzerine alan öğe, uygulamamız çalıştığı anda kendisini Ram üzerine yerleştirip çalışmaya hazır bir şekilde tetikte bekler. Bu tür öğelere new diyerek ulaşamayız. Nesnenin adını yazdıktan hemen sonra (Nokta)konularak static olarak işaretlenmiş öğeye ulaşılır. dialogresult.ok şeklinde ama orda gelen enum değerleridir..
        
        Bir öğeyi static olarak işaretlemeden önce şu soruları mutlaka sormak gerekir.
        
        *"Bu öğe ne kadar sıklıkla kullanılacak?", 
        *"bu öğeyi kullanmak için mutlaka bir nesne gerekir mi?"
        
        Eğer öğeyi çok sık kullanacaksak ve kullanmak içinde instance a ihtiyaç yoksa onu static olarak işaretleyebiliriz.
        
        Static olarak işaretlenmiş öğe içerisinden o nesneye ait -this anahtar kelimesini kullanarak diğer static olmayan öğelere ulaşamayız

        Field,metotlar,propertyler static olarak işaretlenebilir hatta class ı bile.

        */
    public class Firma
    {
        public string Adi { get; set; }
        public static string KendiAdimiz = "Muhammet";
        public static void TumFirmalariListele()
        {
            //KendiAdimiz --> static olan
            //this --> static olmayan
        }
        public void MesajGonder()
        {
        }
    }
}
