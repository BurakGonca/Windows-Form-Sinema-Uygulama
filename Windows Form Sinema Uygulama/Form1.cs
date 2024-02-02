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
            string kullanici = "burak";
            string sifre = "1234";
            string sifreGirisi = textBox2.Text.ToString();
            string kullaniciGirisi = textBox1.Text.ToString().ToLower();

            if (sifreGirisi == sifre && kullaniciGirisi == kullanici)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
            else
            {
                if (sifreGirisi != sifre && kullaniciGirisi == kullanici)
                {
                    MessageBox.Show("Þifrenizi hatalý girdiniz");
                }
                else if (kullaniciGirisi != kullanici && sifreGirisi == sifre)
                {
                    MessageBox.Show("Kullanýcý adýnýzý hatalý girdiniz");
                }
                else
                {
                    MessageBox.Show("Hem kullanýcý adýnýzý\nHem de þifrenizi hatalý girdiniz");
                }
            }
        }


    }
}