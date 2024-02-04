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
    public partial class Form2 : Form
    {
        private Form1 form1;
        private Form3 form3;
        public Sinema Snm { get; set; }
        public Sinema EsaretinBedeli { get; set; }
        public Sinema GodFather { get; set; }
        public Sinema StarWars { get; set; }
        public Sinema HarryPotter { get; set; }

        public Form2(Form _form1)
        {
            InitializeComponent();
            form3 = new Form3(this, Snm);
            form1 = (Form1)_form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            EsaretinBedeli = new Sinema("Esaretin Bedeli",100,200);
            form3 = new Form3(this,EsaretinBedeli);
            form3.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            GodFather = new Sinema("The GodFather", 150, 250);
            form3 = new Form3(this, GodFather);
            form3.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            StarWars = new Sinema("Star Wars", 80, 300);
            form3 = new Form3(this, StarWars);
            form3.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            HarryPotter = new Sinema("Harry Potter", 150, 200);
            form3 = new Form3(this, HarryPotter);
            form3.Show();
            this.Hide();
        }
        
        private void durumBilgisiButton_Click(object sender, EventArgs e)
        {
            label3.Text = Snm.TamBiletAdeti.ToString();
            label4.Text = Snm.Ciro.ToString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

    public interface IFilm
    {
        public string FilmAdi { get; set; }
        public uint Kapasite { get; set; }
        public uint BiletFiyati { get; set; }

    }
    public class Sinema : IFilm
    {
        public string FilmAdi { get; set; }
        public uint Kapasite { get; set; }
        public uint BiletFiyati { get; set; }
        public int TamBiletAdeti { get; private set; } 
        
        public Sinema(string filmAdi, uint kapasite, uint tam)
        {
            this.FilmAdi = filmAdi;
            this.Kapasite = kapasite;
            this.BiletFiyati = tam;

        }
        public decimal Ciro
        {
            get
            {
                return this.TamBiletAdeti * this.BiletFiyati;
            }
        }
        public void BiletSatisi(int BiletAdeti)
        {
            if (BiletAdeti <= BosKoltukAdeti)
            {
                this.TamBiletAdeti += BiletAdeti;

                MessageBox.Show("Bilet satışı gerçekleştirildi");
            }
            else
            {
                MessageBox.Show(BosKoltukAdeti + " adet boş koltuk olduğundan işlem gerçekleşmedi");
            }
        }
        public void BiletIadesi(int biletAdeti)
        {
            if (biletAdeti <= this.TamBiletAdeti)
            {
                this.TamBiletAdeti -= biletAdeti;

                MessageBox.Show("Bilet iadesi gerçekleştirildi");
            }
            else
            {
                MessageBox.Show("Satılmış bilet adetinden fazla iade işlemi yapılamaz.");
            }
        }
        public int BosKoltukAdeti
        {
            get
            {
                return (int)(this.Kapasite - this.TamBiletAdeti);
            }
        }

    }

}
