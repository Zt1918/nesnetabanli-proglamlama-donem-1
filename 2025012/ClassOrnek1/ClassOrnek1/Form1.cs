using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassOrnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Araba yeniAraba;

        private void button1_Click(object sender, EventArgs e)
        {
            yeniAraba = new Araba("Honda", "Civic", "LPG", 1500000);
            label1.Text = yeniAraba.BilgilerYazdir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "satış fiyatı :"+yeniAraba.IndirimYap(15);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "satış fiyatı :" + yeniAraba.FiyatArttir(25);
        }
    }
}
