namespace AllProductsLib
{
    public class Products : getir
    {
        //İnterface Metod
        public string model { get; set; }
        public string aciklama { get; set; }
        public int price { get; set; }
        public void batery()
        {
            model = "Yamaha Batery";
            aciklama = "yamaha batery";
            price = 2000;
        }

        public void gitar()
        {
            model = "Yamaha Gitar";
            aciklama = "yamaha gitar";
            price = 1000;
        }
        public void flut()
        {
            model = "Yamaha Flüt  ";
            aciklama = "yamaha flüt   ";
            price = 500;
        }
        public void davul()
        {
            model = "Yamaha Davul";
            aciklama = "yamaha davul";
            price = 1400;
        }
    }
}
