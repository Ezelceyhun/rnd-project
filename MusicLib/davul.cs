using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLib
{
    public class davul : music
    {
        public override string Sell()
        {
            Model = "Yamaha Davul";
            Aciklama = "yamaha davul";
            Price = 4020 + (4020 * 12) / 100;
            return Model;
        }
    }
}
