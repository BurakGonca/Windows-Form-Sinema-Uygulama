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
        public Form2()
        {
            InitializeComponent();
        }
        Form1 form1 = new Form1();
        Form3 form3 = new Form3();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Sinema esaretinBedeli = new Sinema("Esaretin Bedeli", 100, 200, 100);
            form3.SinemaBilgisi = esaretinBedeli;
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sinema godFather = new Sinema("The GodFather", 150, 250, 125);
            form3.SinemaBilgisi = godFather;
            form3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sinema starWars = new Sinema("Star Wars", 80, 300, 150);
            form3.SinemaBilgisi = starWars;
            form3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sinema harryPotter = new Sinema("Harry Potter", 150, 200, 100);
            form3.SinemaBilgisi = harryPotter;
            form3.Show();
            this.Hide();

        }


    }



    public interface IFilm
    {
        public string FilmAdi { get; set; }
        public uint Kapasite { get; set; }
        public uint TamBiletFiyati { get; set; }
        public uint YarimBiletFiyati { get; set; }

    }
    public class Sinema : IFilm
    {
        public string FilmAdi { get; set; }
        public uint Kapasite { get; set; }
        public uint TamBiletFiyati { get; set; }
        public uint YarimBiletFiyati { get; set; }
        public int ToplamTamBiletAdeti { get; private set; }
        public int ToplamYarimBiletAdeti { get; private set; }

        public Sinema(string filmAdi, uint kapasite, uint tam, uint yarim)
        {
            this.FilmAdi = filmAdi;
            this.Kapasite = kapasite;
            this.TamBiletFiyati = tam;
            this.YarimBiletFiyati = yarim;
        }

    }

    

}
