using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ctor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //new Dukkan(); //Parametre vermediğimiz için yukarıdakini kullanır.
            //new Dukkan("kadıköy", 5); // parametreleri adresne ve ucretne değişkenlerinden ucrete ve adrese aktarır.
            //Dukkan d = new Dukkan();
            //d.Ucret = 5;
            //d.KiralikMi = true; //şeklinde kullandığımızda parametresiz halini kullanırız. Burda her işlem için rame 3 kere gidip geliyor.

            //Object initializer işlemi yukarıdakine alternatif. tüm değişkenleri doldurmamıza gerek yok.
            //Dukkan d3 = new Dukkan()
            //{
            //    Adres = "kadıköy",
            //    Ucret = 5,
            //    OdaSayisi = 3,
            //}; //şeklinde kullandığımızda yine parametresiz halini kullanırız. burda tek seferde tüm işlemi yapıyor.

            //Dukkan d2 = new Dukkan("kadıköy", 5);
            //d2.KiralikMi = true; //şeklinde kullanınca parametreli halini kullanmış oluyoruz.



        }
    }
}
