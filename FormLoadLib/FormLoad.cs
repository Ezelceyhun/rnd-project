namespace FormLoadLib
{
    public class FormLoad
    {
        public string FormBaslik { get; set; }

        public virtual void Form_L()
        {
            FormBaslik = "Giriş Yapmak İçin Butonu Kullanın !";
        }
    }
}
