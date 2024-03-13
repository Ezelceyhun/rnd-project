using AllProductsLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_ve_Tum_Yapılar
{
    public partial class AllProducts : Form
    {
        //İnterface Metod
        gitar gitar = new gitar
        {
            model = "Yamaha Gitar",
            aciklama = "yamaha gitar",
            price = 1000
        };
        flut flut= new flut
        {
            model = "Yamaha Flüt  ",
            aciklama = "yamaha flüt   ",
            price = 500
        };
        davul davul = new davul
        {
            model = "Yamaha Davul",
            aciklama = "yamaha davul",
            price = 1400
        };
        batery batery = new batery
        {
            model = "Yamaha Batery",
            aciklama = "yamaha batery",
            price = 2000
        };

        public AllProducts()
        {
            InitializeComponent();
        }

        private void AllProducts_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Model: "+ gitar.model + "     Açıklaması: "+gitar.aciklama+ "     Fiyatı: "+gitar.price);
            listBox1.Items.Add("Model: " + flut.model + "     Açıklaması: " + flut.aciklama + "    Fiyatı: " + flut.price);
            listBox1.Items.Add("Model: " + davul.model + "    Açıklaması: " + davul.aciklama + "   Fiyatı: " + davul.price);
            listBox1.Items.Add("Model: " + batery.model + "   Açıklaması: " + batery.aciklama + "  Fiyatı: " + batery.price);
        }
    }
}
