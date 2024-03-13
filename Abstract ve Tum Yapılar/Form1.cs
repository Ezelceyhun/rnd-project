using MusicLib;
using FormLoadLib;
namespace Abstract_ve_Tum_Yapılar
{
    public partial class Form1 : Form
    {
        public Form1()
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
            gitar.Model = "Yamaha";
            gitar.Price = 1000;
            gitar.Aciklama = "yamaha gitar";
            string ses = gitar.Sell();
            listBox1.Items.Add("Model: " + gitar.Model + " Gitar");
            listBox2.Items.Add(gitar.Price);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Abstract Metodu
            bateri.Model = "Yamaha";
            bateri.Price = 2000;
            bateri.Aciklama = "yamaha bateri";
            string ses = bateri.Sell();
            listBox2.Items.Add(bateri.Price);
            listBox1.Items.Add("Model: " + bateri.Model + " Bateri");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Abstract Metodu
            flut.Model = "Yamaha";
            flut.Price = 500;
            flut.Aciklama = "yamaha flut";
            string ses = flut.Sell();
            listBox2.Items.Add(flut.Price);
            listBox1.Items.Add("Model: " + flut.Model + " Flüt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Abstract Metodu
            davul.Model = "Yamaha";
            davul.Price = 1400;
            davul.Aciklama = "yamaha davul";
            string ses = davul.Sell();
            listBox2.Items.Add(davul.Price);
            listBox1.Items.Add("Model: " + davul.Model + " Davul");
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
                listBox3.Items.Add("Toplam : " + toplam);
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
            // Constructor Metodu
            FormLoad formLoad = new FormLoad("Satın Almak İstediğiniz Müzik Aletini Seçin");
            label1.Text = formLoad.FromBaslik;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
