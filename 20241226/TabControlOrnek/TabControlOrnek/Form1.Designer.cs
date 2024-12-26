namespace TabControlOrnek
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.numericUpDownCorba = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownİskender = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKofte = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAyran = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTatli = new System.Windows.Forms.NumericUpDown();
            this.lblHesapOzet = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCorba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownİskender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKofte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAyran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTatli)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDownTatli);
            this.tabPage2.Controls.Add(this.numericUpDownAyran);
            this.tabPage2.Controls.Add(this.numericUpDownKofte);
            this.tabPage2.Controls.Add(this.numericUpDownİskender);
            this.tabPage2.Controls.Add(this.numericUpDownCorba);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sipariş Bilgisi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tatlı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ayran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Köfte ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "İskender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Çorba";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblHesapOzet);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sipariş Özeti";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCorba
            // 
            this.numericUpDownCorba.Location = new System.Drawing.Point(73, 48);
            this.numericUpDownCorba.Name = "numericUpDownCorba";
            this.numericUpDownCorba.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCorba.TabIndex = 5;
            // 
            // numericUpDownİskender
            // 
            this.numericUpDownİskender.Location = new System.Drawing.Point(73, 76);
            this.numericUpDownİskender.Name = "numericUpDownİskender";
            this.numericUpDownİskender.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownİskender.TabIndex = 6;
            // 
            // numericUpDownKofte
            // 
            this.numericUpDownKofte.Location = new System.Drawing.Point(73, 111);
            this.numericUpDownKofte.Name = "numericUpDownKofte";
            this.numericUpDownKofte.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownKofte.TabIndex = 7;
            // 
            // numericUpDownAyran
            // 
            this.numericUpDownAyran.Location = new System.Drawing.Point(73, 143);
            this.numericUpDownAyran.Name = "numericUpDownAyran";
            this.numericUpDownAyran.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAyran.TabIndex = 8;
            // 
            // numericUpDownTatli
            // 
            this.numericUpDownTatli.Location = new System.Drawing.Point(73, 177);
            this.numericUpDownTatli.Name = "numericUpDownTatli";
            this.numericUpDownTatli.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTatli.TabIndex = 9;
            // 
            // lblHesapOzet
            // 
            this.lblHesapOzet.AutoSize = true;
            this.lblHesapOzet.Location = new System.Drawing.Point(8, 87);
            this.lblHesapOzet.Name = "lblHesapOzet";
            this.lblHesapOzet.Size = new System.Drawing.Size(92, 16);
            this.lblHesapOzet.TabIndex = 0;
            this.lblHesapOzet.Text = "Hesap Özeti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCorba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownİskender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKofte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAyran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTatli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownKofte;
        private System.Windows.Forms.NumericUpDown numericUpDownİskender;
        private System.Windows.Forms.NumericUpDown numericUpDownCorba;
        private System.Windows.Forms.NumericUpDown numericUpDownTatli;
        private System.Windows.Forms.NumericUpDown numericUpDownAyran;
        private System.Windows.Forms.Label lblHesapOzet;
    }
}

