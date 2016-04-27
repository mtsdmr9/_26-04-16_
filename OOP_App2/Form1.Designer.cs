namespace OOP_App2
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
            this.lstKisi = new System.Windows.Forms.ListBox();
            this.lstSehir = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tKisi = new System.Windows.Forms.TextBox();
            this.tSehir = new System.Windows.Forms.TextBox();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.btnSehirEkle = new System.Windows.Forms.Button();
            this.lstListele = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstKisi
            // 
            this.lstKisi.FormattingEnabled = true;
            this.lstKisi.Location = new System.Drawing.Point(36, 46);
            this.lstKisi.Name = "lstKisi";
            this.lstKisi.Size = new System.Drawing.Size(120, 95);
            this.lstKisi.TabIndex = 0;
            // 
            // lstSehir
            // 
            this.lstSehir.FormattingEnabled = true;
            this.lstSehir.Location = new System.Drawing.Point(162, 46);
            this.lstSehir.Name = "lstSehir";
            this.lstSehir.Size = new System.Drawing.Size(120, 95);
            this.lstSehir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kişiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şehir";
            // 
            // tKisi
            // 
            this.tKisi.Location = new System.Drawing.Point(36, 147);
            this.tKisi.Name = "tKisi";
            this.tKisi.Size = new System.Drawing.Size(100, 20);
            this.tKisi.TabIndex = 4;
            // 
            // tSehir
            // 
            this.tSehir.Location = new System.Drawing.Point(162, 147);
            this.tSehir.Name = "tSehir";
            this.tSehir.Size = new System.Drawing.Size(100, 20);
            this.tSehir.TabIndex = 5;
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.Location = new System.Drawing.Point(36, 173);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKisiEkle.TabIndex = 6;
            this.btnKisiEkle.Text = "button1";
            this.btnKisiEkle.UseVisualStyleBackColor = true;
            this.btnKisiEkle.Click += new System.EventHandler(this.btnKisiEkle_Click);
            // 
            // btnSehirEkle
            // 
            this.btnSehirEkle.Location = new System.Drawing.Point(162, 173);
            this.btnSehirEkle.Name = "btnSehirEkle";
            this.btnSehirEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSehirEkle.TabIndex = 7;
            this.btnSehirEkle.Text = "button2";
            this.btnSehirEkle.UseVisualStyleBackColor = true;
            this.btnSehirEkle.Click += new System.EventHandler(this.btnSehirEkle_Click);
            // 
            // lstListele
            // 
            this.lstListele.FormattingEnabled = true;
            this.lstListele.Location = new System.Drawing.Point(288, 46);
            this.lstListele.Name = "lstListele";
            this.lstListele.Size = new System.Drawing.Size(120, 95);
            this.lstListele.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Listele";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(288, 173);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 10;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstListele);
            this.Controls.Add(this.btnSehirEkle);
            this.Controls.Add(this.btnKisiEkle);
            this.Controls.Add(this.tSehir);
            this.Controls.Add(this.tKisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSehir);
            this.Controls.Add(this.lstKisi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKisi;
        private System.Windows.Forms.ListBox lstSehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tKisi;
        private System.Windows.Forms.TextBox tSehir;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.Button btnSehirEkle;
        private System.Windows.Forms.ListBox lstListele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnListele;
    }
}

