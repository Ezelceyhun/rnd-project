using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLib
{
    public class flut : music
    {
        public override string Sell()
        {
            Model = "Yamaha Flüt";
            Aciklama = "yamaha flüt";
            Price = 560;
            return Model;
        }
    }
}
