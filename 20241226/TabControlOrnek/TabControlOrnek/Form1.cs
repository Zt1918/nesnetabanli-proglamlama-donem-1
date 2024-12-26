using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2) 
            {
                string isim = textBox1.Text;
                double corbaFiyat = 80;
                double iskenderFiyat = 350;
                double kofteFiyat = 220;
                double ayranFiyat = 20;
                double tatliFiyat = 60;

                int corbaAdet =Convert.ToInt32(numericUpDownCorba.Value);
                int iskenderAdet = Convert.ToInt32(numericUpDownİskender.Value);
                int kofteAdet = Convert.ToInt32(numericUpDownKofte.Value);
                int ayranAdet = Convert.ToInt32(numericUpDownAyran.Value);
                int tatliAdet = Convert.ToInt32(numericUpDownTatli.Value);

                double corbaTutar = corbaFiyat * corbaAdet;
                double iskenderTutar = iskenderFiyat * corbaAdet;
                double kofteTutar = kofteFiyat * corbaAdet;
                double ayranTutar = ayranFiyat * corbaAdet;
                double tatliTutar = tatliFiyat * corbaAdet; 

                double toplamTutar = corbaTutar+iskenderTutar+kofteTutar+ayranTutar+tatliTutar;
                lblHesapOzet.Text = "sipariş özeti " + isim + "\n"+corbaAdet + "x" +"çorba= " +corbaTutar + "TL\n"+iskenderAdet  + "x" + "çorba= " + corbaTutar + "TL\n" +







            }
        }
    }
}
