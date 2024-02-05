﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Sinema_Uygulama
{
    public partial class Form3 : Form
    {

        private Form2 form2;
        public Film BiletIslemleri { get; set; }

        public int GenelToplamBiletAdeti { get; set; }

        public Form3(Form _form2, Film _biletIslemleri)
        {
            InitializeComponent();
            form2 = (Form2)_form2;
            BiletIslemleri = _biletIslemleri;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SatisBilgileriGuncelle();
        }
        private void SatisBilgileriGuncelle ()
        {
            label1.Text = $"Filmin Adı                    : {FilmDeposu.SeciliFilm.FilmAdi}\n" +
                          $"Kapasite                      : {FilmDeposu.SeciliFilm.Kapasite} Koltuk\n" +
                          $"Bilet Fiyatı                  : {FilmDeposu.SeciliFilm.BiletFiyati} TL\n" +
                          $"Satılan Bilet Sayısı     : {BiletIslemleri.BiletAdeti}\n" +
                          $"Menu Hasılatı            : {BiletIslemleri.Ciro} TL ";

        }


        private void biletSatButton_Click(object sender, EventArgs e)
        {
            int biletAdeti = (int)numericUpDown1.Value;
            decimal satilanCiro = BiletIslemleri.Ciro;
            BiletIslemleri.BiletSatisi(biletAdeti);
            form2.DurumBilgisiGuncelle(biletAdeti, BiletIslemleri.Ciro - satilanCiro);
        }

        private void biletIadeButton_Click(object sender, EventArgs e)
        {
            int biletAdeti = (int)numericUpDown1.Value;
            decimal satilanCiro = BiletIslemleri.Ciro;
            BiletIslemleri.BiletIadesi(biletAdeti);
            form2.DurumBilgisiGuncelle(-biletAdeti, BiletIslemleri.Ciro - satilanCiro);
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }


    }




}
