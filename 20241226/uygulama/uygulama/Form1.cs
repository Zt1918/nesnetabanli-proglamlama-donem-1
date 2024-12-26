using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            lblNtpKalan.Text = KalanGunHesapla(dtpNesne.Value, lblNtpKalan);
            lblRobatikKalan.Text = KalanGunHesapla(dtpRobatik.Value, lblRobatikKalan);
            lblEdebiyatKalan.Text = KalanGunHesapla(dtpEdebiyat.Value, lblEdebiyatKalan);
        }
         private string KalanGunHesapla(DateTime tarih,Label label)
            {
                string mesaj = "";
                DateTime bugun = DateTime.Now;
                TimeSpan fark = tarih - bugun;
                if (fark.TotalDays < 0)
                {
                    mesaj = "sınav tarihi geçti.";
                    label.ForeColor = Color.Red;
                }
                else if (fark.Days == 0)
                {
                    mesaj = "sınav bugün yapılacak. inşallah hazırsınızdır.";
                }
                else
                {
                    mesaj = "sınav "+ fark.Days+"gün kaldı.";
                }
                return mesaj;
        }
    }
}
