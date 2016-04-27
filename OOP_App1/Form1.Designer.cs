namespace OOP_App1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnYe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnWc = new System.Windows.Forms.Button();
            this.btnUyu = new System.Windows.Forms.Button();
            this.btnBit = new System.Windows.Forms.Button();
            this.btnOyun = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.lblCan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYe
            // 
            this.btnYe.Location = new System.Drawing.Point(12, 160);
            this.btnYe.Name = "btnYe";
            this.btnYe.Size = new System.Drawing.Size(75, 23);
            this.btnYe.TabIndex = 0;
            this.btnYe.Text = "Yemek Ye";
            this.btnYe.UseVisualStyleBackColor = true;
            this.btnYe.Click += new System.EventHandler(this.btnYe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_App1.Properties.Resources.aglayan;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnWc
            // 
            this.btnWc.Location = new System.Drawing.Point(93, 160);
            this.btnWc.Name = "btnWc";
            this.btnWc.Size = new System.Drawing.Size(75, 23);
            this.btnWc.TabIndex = 2;
            this.btnWc.Text = "Wc";
            this.btnWc.UseVisualStyleBackColor = true;
            this.btnWc.Click += new System.EventHandler(this.btnWc_Click);
            // 
            // btnUyu
            // 
            this.btnUyu.Location = new System.Drawing.Point(12, 189);
            this.btnUyu.Name = "btnUyu";
            this.btnUyu.Size = new System.Drawing.Size(75, 23);
            this.btnUyu.TabIndex = 3;
            this.btnUyu.Text = "Uyu";
            this.btnUyu.UseVisualStyleBackColor = true;
            this.btnUyu.Click += new System.EventHandler(this.btnUyu_Click);
            // 
            // btnBit
            // 
            this.btnBit.Location = new System.Drawing.Point(93, 189);
            this.btnBit.Name = "btnBit";
            this.btnBit.Size = new System.Drawing.Size(75, 23);
            this.btnBit.TabIndex = 4;
            this.btnBit.Text = "Finish Him";
            this.btnBit.UseVisualStyleBackColor = true;
            this.btnBit.Click += new System.EventHandler(this.btnBit_Click);
            // 
            // btnOyun
            // 
            this.btnOyun.Location = new System.Drawing.Point(174, 160);
            this.btnOyun.Name = "btnOyun";
            this.btnOyun.Size = new System.Drawing.Size(75, 23);
            this.btnOyun.TabIndex = 5;
            this.btnOyun.Text = "Oyun Başlat";
            this.btnOyun.UseVisualStyleBackColor = true;
            this.btnOyun.Click += new System.EventHandler(this.btnOyun_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(9, 225);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Durum: ";
            // 
            // lblDurum
            // 
            this.lblDurum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDurum.Location = new System.Drawing.Point(59, 215);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(190, 23);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t1
            // 
            this.t1.Interval = 1000;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // lblCan
            // 
            this.lblCan.AutoSize = true;
            this.lblCan.Location = new System.Drawing.Point(59, 247);
            this.lblCan.Name = "lblCan";
            this.lblCan.Size = new System.Drawing.Size(0, 13);
            this.lblCan.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 328);
            this.Controls.Add(this.lblCan);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnOyun);
            this.Controls.Add(this.btnBit);
            this.Controls.Add(this.btnUyu);
            this.Controls.Add(this.btnWc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnYe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnWc;
        private System.Windows.Forms.Button btnUyu;
        private System.Windows.Forms.Button btnBit;
        private System.Windows.Forms.Button btnOyun;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Label lblCan;
    }
}

