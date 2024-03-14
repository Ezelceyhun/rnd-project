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
        public AllProducts()
        {
            InitializeComponent();
        }

        private void AllProducts_Load(object sender, EventArgs e)
        {
            //İnterface Metod
            Products products = new Products();
            products.gitar();
            listBox1.Items.Add("Model: "+ products.model + "     Açıklaması: "+products.aciklama+ "     Fiyatı: "+ products.price);
            products.flut();
            listBox1.Items.Add("Model: " + products.model + "     Açıklaması: " + products.aciklama + "    Fiyatı: " + products.price);
            products.davul();
            listBox1.Items.Add("Model: " + products.model + "    Açıklaması: " + products.aciklama + "   Fiyatı: " + products.price);
            products.batery();
            listBox1.Items.Add("Model: " + products.model + "   Açıklaması: " + products.aciklama + "  Fiyatı: " + products.price);
        }
    }
}
