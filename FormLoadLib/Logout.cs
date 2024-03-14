using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLoadLib
{
    public class Logout : FormLoad
    {
        //Virtual - Override Kullanımı
        public override void Form_L()
        {
            FormBaslik = "Çıkış Yapıldı !";
        }
    }
}
