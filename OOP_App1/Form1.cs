using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_App1
{
    public partial class Form1 : Form
    {
        BabyAppClass bebis = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOyun_Click(object sender, EventArgs e)
        {
            bebis =new BabyAppClass(1000);
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                }
            }
            btnOyun.Enabled = false;
            t1.Start();
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            if (bebis!=null)
            {
                if (bebis.Hayat>5000)lblDurum.Text = "bebiş ohh miss";
                if (bebis.Hayat > 1100 || bebis.Hayat<1000) lblDurum.Text = "çok yedirdin yada hiç yedirmedin";
                if (bebis.Hayat > 9000) lblDurum.Text = "Wc ye koş";
                if (bebis.Hayat == 0)
                {
                    t1.Stop();
                    MessageBox.Show("Bebiş ....");
                    foreach (Control c in this.Controls)
                    {
                        if (c is Button)
                            
                        {
                            c.Enabled = false;
                        }
                    }
                    this.bebis = null;
                }
                if (bebis!=null)
                {
                    this.bebis.Hayat -= 10;
                lblCan.Text = bebis.Hayat.ToString();
                }
            }
        }

        private void btnYe_Click(object sender, EventArgs e)
        {
            bebis.YemekYedir();
        }

        private void btnWc_Click(object sender, EventArgs e)
        {
            bebis.Tuvalet();
        }

        private void btnUyu_Click(object sender, EventArgs e)
        {
            bebis.Uyut();
        }

        private void btnBit_Click(object sender, EventArgs e)
        {
            
            bebis.FinishHim();
            
        }
    }
}
