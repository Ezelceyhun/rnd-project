using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLib
{
    public class gitar : music
    {
        public override string Sell()
        {
            Model = "Yamaha Gitar";
            Aciklama = "yamaha gitar";
            Price = 1500 + (1500 * 5) / 100;
            return Model;
        }
    }
}
