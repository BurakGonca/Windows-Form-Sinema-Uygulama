namespace Windows_Form_Sinema_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici[] kullaniciDizi = new Kullanici[3];

            kullaniciDizi[0] = new Kullanici("burak", "1234");
            kullaniciDizi[1] = new Kullanici("gonca", "4321");
            kullaniciDizi[2] = new Kullanici("burki", "1991");
            
            string kullaniciGirisi = textBox1.Text.ToLower();
            string sifreGirisi = textBox2.Text;

            bool kullaniciAdiDogruMu = false;

            for (int i = 0; i < 3; i++)
            {
                if (kullaniciDizi[i].KullaniciAdi == kullaniciGirisi)
                {
                    kullaniciAdiDogruMu = true;

                    if (kullaniciDizi[i].Sifre == sifreGirisi)
                    {
                        Form2 form2 = new Form2(this);
                        this.Hide();
                        form2.Show();
                        return; 
                    }
                    else
                    {
                        MessageBox.Show("Þifrenizi hatalý girdiniz");
                        return; 
                    }
                }
            }

            if (!kullaniciAdiDogruMu)
            {
                MessageBox.Show("Kullanýcý adýnýzý hatalý girdiniz");
            }
            else
            {
                MessageBox.Show("Hem kullanýcý adýnýzý, Hem de þifrenizi hatalý girdiniz");
            }


        }


    }

    public class Kullanici
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public Kullanici(string kullaniciAdi, string sifre)
        {
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
        }

    }


}