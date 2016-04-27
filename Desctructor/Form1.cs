using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desctructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mahkum m = new Mahkum()
            {
                AdSoyad = "batuhan",
                KimlikNo = "123",
                Suc = Mahkum.SucTipi.Gasp
            };
        }
    }
    //Yıkıcı 
    class Mahkum: IDisposable
    {
        public string KimlikNo { get; set; }
        public string AdSoyad { get; set; }
        public SucTipi Suc{ get; set; }
        public Mahkum(){}
        //Yıkıcı Metot ,nesne ramden atılırken devreye girer ve classın yapması gereken son işler var ise bu destructor içinde gerçekleştirilir.
        //~Mahkum()
        //{
        //    MessageBox.Show("Son bi cigara yakayım.");
        //}
        public enum SucTipi
        {
            Kader,
            Cinayet,
            Gasp
        }
        //Yıkıcı metotla dispose arasındaki fark. atılmadan önceki son aşama yıkıcı metottur. tam atılmamış ama gidiyorken gerçekleştirilir.
        //garbagecollector uygulama izleri silindikten sonra gerçekleştirilir.
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
