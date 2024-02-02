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
        public Form3(Form _form2)
        {
            InitializeComponent();
            form2 = (Form2)_form2;
        }
        public Sinema SinemaBilgisi { get; set; }
        

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = $"Filmin Adı             : {SinemaBilgisi.FilmAdi}\n" +
                          $"Kapasite               : {SinemaBilgisi.Kapasite} Koltuk\n" +
                          $"Tam Bilet Fiyatı    : {SinemaBilgisi.TamBiletFiyati} TL\n" +
                          $"Yarım Bilet Fiyatı : {SinemaBilgisi.YarimBiletFiyati} TL";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }
    }




}
