using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLib
{
    public class Purchaser : Odul
    {
        //İnterface Metodu
        public string Name { get; set; }
        public double TotalPay { get; set; }
        public string Message { get; set; }
        public void discounted100()
        {
            Message = "Sayın "+ Name + ". "+ TotalPay + "₺ Tutarında Alışveriş Yaptınız. Sonraki Alışveriş İçin 100₺ Ödül Kazandınız!";
        }
        public void discounted500()
        {
            Message = "Sayın " + Name + ". " + TotalPay + "₺ Tutarında Alışveriş Yaptınız. Sonraki Alışveriş İçin 500₺ Ödül Kazandınız!";
        }
        public void discountedUnLimited()
        {
            Message = "Sayın " + Name + ". " + TotalPay + "₺ Tutarında Alışveriş Yaptınız. Sonraki Alışveriş İçin 1000₺ Ödül Kazandınız!";
        }
    }
    interface Odul
    {
        //İnterface Metodu
        void discounted100();
        void discounted500();
        void discountedUnLimited();
    }
}
