using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MusicLib
{
    public class bateri : music
    {
        public override string Sell()
        {
            Model = "Yamaha Batery";
            Aciklama = "yamaha batery";
            Price = 5140 + (5140 * 9) / 100;
            return Model;
        }
    }
}
