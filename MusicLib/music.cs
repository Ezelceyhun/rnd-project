
namespace MusicLib
{
    public class music 
    {
        //Polymorphism
        public string Model {  get; set; }
        public string Aciklama{ get; set; }
        public int Price { get; set; }
        public virtual string Sell()
        {
            return Model;
        }

    }
}
