using System;

namespace FieldPropertyAuto
{
    class Program
    {
        class Insan
        {
        private string isim; //field - alan
        private int yas;

        public string Isim  // property - mülk 
        {
            get { return isim; }  //almak
            set{ isim = value; }  // Kurmak     value-deger
        }
        public int Yas // property - mülk
        {
            get {return yas; }
            set {if (value < 0) yas = value;}
        }

        //Auto-implemented property
        public Insan(string cinsiyet)
        {
            this.Cinsiyet = cinsiyet;
        }
        public string Cinsiyet {get;}

        }
        static void Main(string[] args)
        {
            Insan i1 = new Insan("Erkek");
            i1.Isim = "Ferhat Dövme";
            i1.Yas = 10;
            //i1.Cinsiyet = "Erkek";
            Console.WriteLine(i1.Isim + " " + i1.Yas + " " + i1.Cinsiyet);
        }
    }
}
