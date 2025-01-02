using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassOrnek1
{
    internal class Araba
    {
        string marka;
        string model;
        string yakıtturu;
        decimal fiyat;

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Yakıtturu { get => yakıtturu; set => yakıtturu = value; }
        public decimal Fiyat { get => fiyat; set => fiyat = value; }

        public Araba(string marka, string model, string yakıtturu, decimal fiyat)
        {
            Marka = marka;
            Model = model;
            Yakıtturu = yakıtturu;
            Fiyat = fiyat;
        }
        public string BilgilerYazdir()
        {
            string s= $"Marka: {Marka}\nModel{Model}\nYakıt Türü:{Yakıtturu}\n {fiyat}\n";
            return s;
        }
        public decimal IndirimYap(int oran)
        {
            decimal indirimliFiyat = fiyat - (fiyat * oran / 100);
            return indirimliFiyat;
        }
        public decimal FiyatArttir(int oran) 
        { 
            decimal zamliFiyat = fiyat +(fiyat * oran / 100);
            return zamliFiyat;
        }
    }
}
