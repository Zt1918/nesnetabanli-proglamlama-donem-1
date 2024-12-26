namespace uygulama
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.dtpNesne = new System.Windows.Forms.DateTimePicker();
            this.dtpRobatik = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEdebiyat = new System.Windows.Forms.DateTimePicker();
            this.lblNtpKalan = new System.Windows.Forms.Label();
            this.lblRobatikKalan = new System.Windows.Forms.Label();
            this.lblEdebiyatKalan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nesne Tabanlı Proglama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Robatik Kodlama";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(248, 150);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // dtpNesne
            // 
            this.dtpNesne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpNesne.Location = new System.Drawing.Point(184, 43);
            this.dtpNesne.Name = "dtpNesne";
            this.dtpNesne.Size = new System.Drawing.Size(200, 21);
            this.dtpNesne.TabIndex = 3;
            // 
            // dtpRobatik
            // 
            this.dtpRobatik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpRobatik.Location = new System.Drawing.Point(184, 83);
            this.dtpRobatik.Name = "dtpRobatik";
            this.dtpRobatik.Size = new System.Drawing.Size(200, 21);
            this.dtpRobatik.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edebiyat Dinleme";
            // 
            // dtpEdebiyat
            // 
            this.dtpEdebiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpEdebiyat.Location = new System.Drawing.Point(184, 114);
            this.dtpEdebiyat.Name = "dtpEdebiyat";
            this.dtpEdebiyat.Size = new System.Drawing.Size(200, 21);
            this.dtpEdebiyat.TabIndex = 6;
            // 
            // lblNtpKalan
            // 
            this.lblNtpKalan.AutoSize = true;
            this.lblNtpKalan.Location = new System.Drawing.Point(390, 43);
            this.lblNtpKalan.Name = "lblNtpKalan";
            this.lblNtpKalan.Size = new System.Drawing.Size(0, 13);
            this.lblNtpKalan.TabIndex = 7;
            // 
            // lblRobatikKalan
            // 
            this.lblRobatikKalan.AutoSize = true;
            this.lblRobatikKalan.Location = new System.Drawing.Point(390, 88);
            this.lblRobatikKalan.Name = "lblRobatikKalan";
            this.lblRobatikKalan.Size = new System.Drawing.Size(0, 13);
            this.lblRobatikKalan.TabIndex = 8;
            // 
            // lblEdebiyatKalan
            // 
            this.lblEdebiyatKalan.AutoSize = true;
            this.lblEdebiyatKalan.Location = new System.Drawing.Point(390, 121);
            this.lblEdebiyatKalan.Name = "lblEdebiyatKalan";
            this.lblEdebiyatKalan.Size = new System.Drawing.Size(0, 13);
            this.lblEdebiyatKalan.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(571, 263);
            this.Controls.Add(this.lblEdebiyatKalan);
            this.Controls.Add(this.lblRobatikKalan);
            this.Controls.Add(this.lblNtpKalan);
            this.Controls.Add(this.dtpEdebiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpRobatik);
            this.Controls.Add(this.dtpNesne);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.DateTimePicker dtpNesne;
        private System.Windows.Forms.DateTimePicker dtpRobatik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEdebiyat;
        private System.Windows.Forms.Label lblNtpKalan;
        private System.Windows.Forms.Label lblRobatikKalan;
        private System.Windows.Forms.Label lblEdebiyatKalan;
    }
}

