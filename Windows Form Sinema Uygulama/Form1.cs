namespace Windows_Form_Sinema_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kullanici[] kullaniciDizi = new Kullanici[3];

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Kullanýcý Adý")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Kullanýcý Adý";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Kullanýcý Adý";
            textBox1.ForeColor = Color.Silver;
            textBox2.Text = "Sifre";
            textBox2.ForeColor = Color.Silver;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Sifre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Sifre";
                textBox2.ForeColor = Color.Silver;
            }
        }

        
    }

    public class Kullanici
    {
        public string KullaniciAdi { get; }
        public string Sifre { get; }

        internal Kullanici(string kullaniciAdi, string sifre)
        {
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
        }

    }


}