namespace MusicLib
{
    public abstract class music
    {
        //Polymorphism
        public string Model {  get; set; }
        public string Aciklama{ get; set; }
        public int Price { get; set; }
        public abstract string Sell();
    }
}
