namespace Lokanta
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numSutlac = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numAyran = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numEt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numTavuk = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numCorba = new System.Windows.Forms.NumericUpDown();
            this.lblYemek1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblSiparisFis = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSutlac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAyran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTavuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCorba)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 383);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtMusteri);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(276, 142);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(225, 29);
            this.txtMusteri.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numSutlac);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.numAyran);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.numEt);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.numTavuk);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numCorba);
            this.tabPage2.Controls.Add(this.lblYemek1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sipariş Bilgileri";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // numSutlac
            // 
            this.numSutlac.Location = new System.Drawing.Point(365, 212);
            this.numSutlac.Name = "numSutlac";
            this.numSutlac.Size = new System.Drawing.Size(120, 29);
            this.numSutlac.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sütlaç";
            // 
            // numAyran
            // 
            this.numAyran.Location = new System.Drawing.Point(365, 177);
            this.numAyran.Name = "numAyran";
            this.numAyran.Size = new System.Drawing.Size(120, 29);
            this.numAyran.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ayran";
            // 
            // numEt
            // 
            this.numEt.Location = new System.Drawing.Point(365, 142);
            this.numEt.Name = "numEt";
            this.numEt.Size = new System.Drawing.Size(120, 29);
            this.numEt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Et Döner";
            // 
            // numTavuk
            // 
            this.numTavuk.Location = new System.Drawing.Point(365, 107);
            this.numTavuk.Name = "numTavuk";
            this.numTavuk.Size = new System.Drawing.Size(120, 29);
            this.numTavuk.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tavuk Döner";
            // 
            // numCorba
            // 
            this.numCorba.Location = new System.Drawing.Point(365, 72);
            this.numCorba.Name = "numCorba";
            this.numCorba.Size = new System.Drawing.Size(120, 29);
            this.numCorba.TabIndex = 1;
            // 
            // lblYemek1
            // 
            this.lblYemek1.AutoSize = true;
            this.lblYemek1.Location = new System.Drawing.Point(239, 74);
            this.lblYemek1.Name = "lblYemek1";
            this.lblYemek1.Size = new System.Drawing.Size(61, 24);
            this.lblYemek1.TabIndex = 0;
            this.lblYemek1.Text = "Çorba";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblSiparisFis);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(776, 346);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sipariş Fişi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblSiparisFis
            // 
            this.lblSiparisFis.AutoSize = true;
            this.lblSiparisFis.Location = new System.Drawing.Point(17, 25);
            this.lblSiparisFis.Name = "lblSiparisFis";
            this.lblSiparisFis.Size = new System.Drawing.Size(101, 24);
            this.lblSiparisFis.TabIndex = 0;
            this.lblSiparisFis.Text = "Sipariş Fiş:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 383);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSutlac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAyran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTavuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCorba)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numEt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTavuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCorba;
        private System.Windows.Forms.Label lblYemek1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown numSutlac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numAyran;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSiparisFis;
    }
}

