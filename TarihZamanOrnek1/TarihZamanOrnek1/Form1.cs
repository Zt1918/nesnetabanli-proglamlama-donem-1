﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarihZamanOrnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDateTimeYear_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            label1.Text = bugun.DayOfYear.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            label1.Text = bugun.DayOfWeek.ToString();
        }
    }
}
