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
        public void Discounted100()
        {
            Message = "Sayın "+ Name + ". "+ TotalPay + "₺ Tutarında Alışveriş Yaptınız. Sonraki Alışveriş İçin 100₺ Ödül Kazandınız!";
        }
        public void Discounted500()
        {
            Message = "Sayın " + Name + ". " + TotalPay + "₺ Tutarında Alışveriş Yaptınız. Sonraki Alışveriş İçin 500₺ Ödül Kazandınız!";
        }
        public void DiscountedUnLimited()
        {
            Message = "Sayın " + Name + ". " + TotalPay + "₺ Tutarında Alışveriş Yaptınız. Sonraki Alışveriş İçin 1000₺ Ödül Kazandınız!";
        }
    }
    interface Odul
    {
        //İnterface Metodu
        void Discounted100();
        void Discounted500();
        void DiscountedUnLimited();
    }
}
