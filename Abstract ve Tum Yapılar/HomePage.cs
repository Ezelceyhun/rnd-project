using MusicLib;
using FormLoadLib;
namespace Abstract_ve_Tum_Yapılar
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        //Abstract Metodu
        flut flut = new flut();
        davul davul = new davul();
        gitar gitar = new gitar();
        bateri bateri = new bateri();
        purchaser purchaser = new purchaser();
        private void button1_Click(object sender, EventArgs e)
        {
            //Abstract Metodu
            gitar.Sell();
            listBox1.Items.Add("Model: " + gitar.Model);
            listBox2.Items.Add(gitar.Price);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Abstract Metodu
            bateri.Sell();
            listBox2.Items.Add(bateri.Price);
            listBox1.Items.Add("Model: " + bateri.Model);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Abstract Metodu
            flut.Sell();
            listBox2.Items.Add(flut.Price);
            listBox1.Items.Add("Model: " + flut.Model);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Abstract Metodu
            davul.Sell();
            listBox2.Items.Add(davul.Price);
            listBox1.Items.Add("Model: " + davul.Model);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Abstract Metodu
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen İsminizi Girin!");
            }
            else
            {
                double toplam = 0;
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    toplam += Convert.ToDouble(listBox2.Items[i]);
                }
                listBox3.Items.Clear();
                listBox3.Items.Add("Toplam : " + toplam + " ₺");
                purchaser.name = textBox1.Text;
                textBox1.Text = "";
                label3.Text = purchaser.name;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Metinleri Temizle
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            label3.Text = "";
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Constructor Metodu
            panel1.Hide();
            FormLoad formLoad = new FormLoad();
            formLoad.Form_L();
            label1.Text = formLoad.FormBaslik;
            logout_btn.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            //İnterface Metod Butonu
            AllProducts next = new AllProducts();
            next.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            //Virtual - Override Kullanımı
            FormLoad formLoad = new Login();
            formLoad.Form_L();
            label1.Text = formLoad.FormBaslik;
            panel1.Show();
            login_btn.Hide();
            logout_btn.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            //Virtual - Override Kullanımı
            FormLoad formLoad = new Logout();
            formLoad.Form_L();
            label1.Text = formLoad.FormBaslik;
            panel1.Hide();
            logout_btn.Hide();
            login_btn.Show();
        }
    }
}
