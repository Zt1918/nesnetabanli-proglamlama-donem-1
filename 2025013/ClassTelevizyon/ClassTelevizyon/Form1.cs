using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassTelevizyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        List<Televizyon> televizyonListesi=new List<Televizyon>();

        private void Form1_Load(object sender, EventArgs e)
        {
            televizyonListesi.Add(new Televizyon("Samsung", "Android", 75, 38000, true));
            televizyonListesi.Add(new Televizyon("LG", "Web OS", 55, 24000, true));
            televizyonListesi.Add(new Televizyon("TLC", "Android", 75, 12000, false));
            televizyonListesi.Add(new Televizyon("Arçelik", "Smart", 75, 8000, false));
            televizyonListesi.Add(new Televizyon("LG", "Android", 105, 50000, true));



            //Televizyon televizyon1 = new Televizyon("Samsung", "Android", 75, 38000, true);
            //Televizyon televizyon2 = new Televizyon("LG", "Smart", 75, 30000, false);
            //Televizyon televizyon3 = new Televizyon("Beko", "Web OS", 75, 25000, true);
            //Televizyon televizyon4 = new Televizyon("Vestel", "Android", 75, 12000, true);

            //televizyonListesi.Add(televizyon1);

            Listele();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //EKLE Butonu
            string marka = txtMarka.Text;
            string isletim = txtIsletim.Text;
            int boyut = Convert.ToInt32(txtBoyut.Text);
            decimal fiyat = Convert.ToDecimal(txtFiyat.Text);
            bool stok = chkStok.Checked;

            Televizyon tv=new Televizyon(marka, isletim, boyut, fiyat,stok);

            televizyonListesi.Add(tv);

            Listele();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SİL butonu
            DataGridViewRow secilenSatir = dgvTelevizyon.SelectedRows[0];
            Televizyon secilenTv=secilenSatir.DataBoundItem as Televizyon;
            televizyonListesi.Remove(secilenTv); //listeden kaldır
            Listele();
        }

        void Listele()
        {
            dgvTelevizyon.DataSource = televizyonListesi.ToList();
        }


    }
}
