using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Enum: sabitler. Genelde enumu değişmeyen yapılar için kullanılır. Haftanın günleri, yazılımcı, yönetici, yılın ayları, dialogresult. dediğimizde gelen ok yes no gibi daha önce tanımlanmış ve değiştirilemeyecek değerler olarak tanımlanabilir.
        //ÖR:
        enum Roller
        {
            Gold,
            Silver,
            Platinium,
            Brons
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Roller.Brons şeklinde örneklendirilebilir.
            //switch (Roller) //Burada switch code snippet: tab tab sonrasında roller yazıp entera basınca kendisi doldurur.
            //{
            //    case Roller.Gold:
            //        MessageBox.Show("Merhaba Gold Üye");
            //        break;
            //    case Roller.Silver:
            //        break;
            //    case Roller.Platinium:
            //        break;
            //    case Roller.Brons:
            //        break;
            //    default:
            //        break;
            //}

            EvYemekleri doner = new EvYemekleri();
            doner.EtSunum = EvYemekleri.EtSunumTipleri.Haslama;
            doner.Adi = "Kuru Fasulye";
        }
    }
    //enum Aylar
    //{
    //    Ocak,
    //    Şubat,
    //    Mart,
    //    Nisan,
    //    Mayıs,
    //    Haziran,
    //    Temmuz,
    //    Ağustos,
    //    Eylül,
    //    Ekim,
    //    Kasım,
    //    Aralık
    //}
}
