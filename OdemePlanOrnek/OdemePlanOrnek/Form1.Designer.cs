namespace OdemePlanOrnek
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTaksit = new System.Windows.Forms.ComboBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(86, 14);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(133, 20);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(86, 40);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(133, 20);
            this.txtUrunFiyati.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Fiyatı";
            // 
            // cmbTaksit
            // 
            this.cmbTaksit.FormattingEnabled = true;
            this.cmbTaksit.Items.AddRange(new object[] {
            "Peşin"});
            this.cmbTaksit.Location = new System.Drawing.Point(86, 66);
            this.cmbTaksit.Name = "cmbTaksit";
            this.cmbTaksit.Size = new System.Drawing.Size(133, 21);
            this.cmbTaksit.TabIndex = 4;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(102, 93);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(101, 27);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(228, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(334, 355);
            this.listBox1.TabIndex = 6;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(5, 219);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(179, 16);
            this.lblToplamTutar.TabIndex = 7;
            this.lblToplamTutar.Text = "Toplam Ödenecek Tutar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.cmbTaksit);
            this.Controls.Add(this.txtUrunFiyati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTaksit;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}

