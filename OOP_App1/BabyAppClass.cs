using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_App1
{
   public class BabyAppClass
    {
        public string Adi { get; set; }
        public int? Hayat { get; set; }
public BabyAppClass()
        {
            //ctor
            Hayat = 1000;
            System.Windows.Forms.MessageBox.Show("Bebek hayata geldi");
        }
        public BabyAppClass(int _hayat)
        {
            this.Hayat = _hayat;
            System.Windows.Forms.MessageBox.Show("Bebek hayata geldi.");
        }

        //Metotlar
        public void YemekYedir()
        {
            Hayat += 100;
        }
        public  void Tuvalet()
        {
            Hayat -= 150;
        }
        public void FinishHim()
        {
            Hayat = 0;
        }
        public void Uyut()
        {
            Hayat += 20;
        }

    }
}
