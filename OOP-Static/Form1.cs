using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Firma.KendiAdimiz --> static olan kendi içindekini hemen getirir.
            //Firma f = new Firma(); // static olmayanda istediğimiz gibi nesneleri adlandırıp yeni nesneleme yapılabilir ancak static de tek bir değer ataması yapılabilir.
            //f.Adi = "sa";
            //f.MesajGonder();
            
        }
    }
}
