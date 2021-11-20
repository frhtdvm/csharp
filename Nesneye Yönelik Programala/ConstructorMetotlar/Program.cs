using System;

namespace ConstructorMetotlar
{
    class Program
    {
        class Insan
        {
            int yas;
            string isim;

            public Insan()
            {
                Console.WriteLine("Yeni bir Obje Yaratildi");
            }
            public Insan(string isim)
            {
                this.isim = isim;
            }
            public Insan(string isim, int yas)
            {
                this.isim = isim;
                this.yas = yas;
            }
            public void bilgileriSoyle()
            {
                Console.WriteLine("Adim {0} yasim {1}", isim, yas);
            }
        }
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan("Ferhat Dövme");
            Insan i3 = new Insan("Ferhat", 33);

            i2.bilgileriSoyle();
            i3.bilgileriSoyle();
        }
    }
}
