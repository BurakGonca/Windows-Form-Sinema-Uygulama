using System;
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
        public Sinema Snm { get; set; }

        public Form3(Form _form2, Sinema _snm)
        {
            InitializeComponent();
            form2 = (Form2)_form2;
            Snm = _snm;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = $"Filmin Adı             : {Snm.FilmAdi}\n" +
                          $"Kapasite               : {Snm.Kapasite} Koltuk\n" +
                          $"Bilet Fiyatı           : {Snm.BiletFiyati} TL\n" +
                          $"Satılan Bilet Sayısı   : {Snm.TamBiletAdeti}\n" +
                          $"Ciro                   : {Snm.Ciro} TL ";


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void biletSatButton_Click(object sender, EventArgs e)
        {
            int biletAdeti = (int) numericUpDown1.Value;
            Snm.BiletSatisi(biletAdeti);
        }

        private void biletIadeButton_Click(object sender, EventArgs e)
        {
            int biletAdeti = (int)numericUpDown1.Value;
            Snm.BiletIadesi(biletAdeti);
        }
    }




}
