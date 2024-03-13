namespace AllProductsLib
{
    public interface Products
    {
        //İnterface Metod
        string model { get; set; }
        string aciklama { get; set; }
        int price { get; set; }
        void goster();
    }
}
