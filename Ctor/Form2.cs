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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            Araba a = new Araba();
            Araba a2 = new Araba(2015, "Mercedes CLA");
            Araba a3 = new Araba("Mercedes", 7.8);
            lstArabalar.Items.Add(a);
            lstArabalar.Items.Add(a2);
            lstArabalar.Items.Add(a3);
        }
    }
    public class Araba
    {

        public int Model = -1;
        public string Maker = string.Empty;
        public double EngineType = 0.0;

        public Araba()
        {
            //Default Constructor (ctor)
        }
        public  Araba(int _model,string _maker)
        {
            Model = _model;
            Maker = _maker;
        }

        public Araba(string _maker,double power)
        {
            Maker = _maker;
            EngineType = power;
        }

        //listbox a normalde bu şekilde aktartığımızda listboxa ctor.araba şeklinde aktarmaması için ToString metodunun override (ezilmesi,kişiselleştirilmesi) gerekir.
        //Bir sınıfın ToString metodu o sınıfın kimlik metodudur.
        //override boşluk, ToString enter
        public override string ToString()
        {
            return Model + ", " + Maker + ", " + EngineType;
        }
    }
}
