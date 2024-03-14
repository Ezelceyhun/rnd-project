using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLoadLib
{
    public class Login : FormLoad
    {
        //Virtual - Override Kullanımı
        public override void Form_L()
        {
            FormBaslik = "Satın Almak İstediğiniz Müzik Aletini Seçin";
        }

    }
}
