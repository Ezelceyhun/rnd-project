namespace FormLoadLib
{
    public class FormLoad
    {
        //Virtual Kullanımı
        public string FormBaslik { get; set; }

        public virtual void Form_L()
        {
            FormBaslik = "Giriş Yapmak İçin Butonu Kullanın !";
        }
    }
}
