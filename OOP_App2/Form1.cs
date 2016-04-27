using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_App2
{
    public partial class Form1 : Form
    {
        //textlerden listelere ekle
        //<List> şeklinde yap.
        //kişilerle şehirleri eşleştir ve listeleye override ile gönder.

        public Form1()
        {
            InitializeComponent();
        }
        List<Kisiler> k = new List<Kisiler>();
        List<Sehirler> s = new List<Sehirler>();
        Kisiler k1;
        Sehirler s1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            k1 = new Kisiler();
            k1.Adi = tKisi.Text;
            k.Add(k1);
            lstKisi.Items.Clear();
            foreach (Kisiler i in k)
            {
                lstKisi.Items.Add(i);
            }
            
        }

        private void btnSehirEkle_Click(object sender, EventArgs e)
        {
            s1 = new Sehirler();
            s1.Adi = tSehir.Text;
            s.Add(s1);
            lstSehir.Items.Clear();
            foreach (Sehirler j in s)
            {
                lstSehir.Items.Add(j);
            }
            
        }
        bool Ayni=false;
        private void btnListele_Click(object sender, EventArgs e)
        {
            k1 = new Kisiler();
            k1.Adi = tKisi.Text;
            k.Add(k1);
            s1 = new Sehirler();
            s1.Adi = tSehir.Text;
            s.Add(s1);
            lstListele.Items.Add(k1 + " " + s1);
        }
    }
}
