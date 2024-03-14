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
            Price = 2000;
            return Model;
        }
    }
}
