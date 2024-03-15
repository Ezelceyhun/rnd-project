using MusicLib;
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
        music flut = new flut();
        music davul = new davul();
        music gitar = new gitar();
        music bateri = new bateri();
        private void AllProducts_Load(object sender, EventArgs e)
        {
            //Polymorphism
            gitar.Sell();
            flut.Sell();
            bateri.Sell();
            davul.Sell();
            listBox1.Items.Add("Model: " + gitar.Model + " - Açıklama: " + gitar.Aciklama + " - Fiyat: " + gitar.Price + " ₺");
            listBox1.Items.Add("Model: " + davul.Model + " - Açıklama: " + davul.Aciklama + " - Fiyat: " + davul.Price + " ₺");
            listBox1.Items.Add("Model: " + flut.Model + " - Açıklama: " + flut.Aciklama + " - Fiyat: " + flut.Price + " ₺");
            listBox1.Items.Add("Model: " + bateri.Model + " - Açıklama: " + bateri.Aciklama + " - Fiyat: " + bateri.Price + " ₺");

        }
    }
}
