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
        public Film Snm { get; set; }
        public Film EsaretinBedeli { get; set; }
        public Film GodFather { get; set; }
        public Film StarWars { get; set; }
        public Film HarryPotter { get; set; }
        public Film ScarFace { get; set; }
        public Film DarkNight { get; set; }
        public Film PulpFiction { get; set; }
        public Film Shrek { get; set; }

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
            EsaretinBedeli = new Film("Esaretin Bedeli", 100, 200);
            FilmDeposu.SeciliFilm = EsaretinBedeli;
            form3 = new Form3(this, FilmDeposu.SeciliFilm);
            form3.Show();
            this.Hide();


        }
        private void button3_Click(object sender, EventArgs e)
        {
            GodFather = new Film("The GodFather", 150, 250);
            FilmDeposu.SeciliFilm = GodFather;
            form3 = new Form3(this, GodFather);
            form3.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            StarWars = new Film("Star Wars", 80, 300);
            FilmDeposu.SeciliFilm = StarWars;
            form3 = new Form3(this, StarWars);
            form3.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            HarryPotter = new Film("Harry Potter", 150, 200);
            FilmDeposu.SeciliFilm = HarryPotter;
            form3 = new Form3(this, HarryPotter);
            form3.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ScarFace = new Film("ScarFace", 200, 250);
            FilmDeposu.SeciliFilm = ScarFace;
            form3 = new Form3(this, ScarFace);
            form3.Show();
            this.Hide();

        }
        private void button7_Click(object sender, EventArgs e)
        {
            DarkNight = new Film("DarkNight", 225, 225);
            FilmDeposu.SeciliFilm = DarkNight;
            form3 = new Form3(this, DarkNight);
            form3.Show();
            this.Hide();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            PulpFiction = new Film("PulpFiction", 250, 300);
            FilmDeposu.SeciliFilm = PulpFiction;
            form3 = new Form3(this, PulpFiction);
            form3.Show();
            this.Hide();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Shrek = new Film("Shrek", 200, 150);
            FilmDeposu.SeciliFilm = Shrek;
            form3 = new Form3(this, Shrek);
            form3.Show();
            this.Hide();
        }




        public int biletAdeti;
        public decimal ciro;
        private void Form2_Load(object sender, EventArgs e)
        {
            biletAdeti = 0;
            ciro = 0;
        }


        public void DurumBilgisiGuncelle(int satilanBiletAdeti, decimal satilanCiro)
        {

            biletAdeti += satilanBiletAdeti;
            ciro += satilanCiro;


        }

        private void durumBilgisiButton_Click(object sender, EventArgs e)
        {
            label3.Text = biletAdeti.ToString();
            label4.Text = ciro.ToString() + " TL";
        }

    }


    public static class FilmDeposu
    {
        public static Film SeciliFilm { get; set; }
    }


    public interface IFilmTip
    {
        public string FilmAdi { get; set; }
        public uint Kapasite { get; set; }
        public uint BiletFiyati { get; set; }

    }


    public class Film : IFilmTip
    {
        public string FilmAdi { get; set; }
        public uint Kapasite { get; set; }
        public uint BiletFiyati { get; set; }
        public int BiletAdeti { get; set; }

        public Film(string filmAdi, uint kapasite, uint tam)
        {
            this.FilmAdi = filmAdi;
            this.Kapasite = kapasite;
            this.BiletFiyati = tam;

        }
        public decimal Ciro
        {
            get
            {
                return this.BiletAdeti * this.BiletFiyati;
            }
        }
        public void BiletSatisi(int _BiletAdeti)
        {
            if (_BiletAdeti <= BosKoltukAdeti)
            {
                this.BiletAdeti += _BiletAdeti;

                MessageBox.Show("Bilet satışı gerçekleştirildi");
            }
            else
            {
                MessageBox.Show(BosKoltukAdeti + " adet boş koltuk olduğundan işlem gerçekleşmedi");
            }
        }
        public void BiletIadesi(int _BiletAdeti)
        {
            if (_BiletAdeti <= this.BiletAdeti)
            {
                this.BiletAdeti -= _BiletAdeti;

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
                return (int)(this.Kapasite - this.BiletAdeti);
            }
        }

    }

}
