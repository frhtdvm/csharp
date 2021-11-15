using System;

namespace Giris
{
    class Program
    {
        //iki insan birbiriyle selamlasacak
        class Insan{
        string isim;
        int yas;
        public void selamVer(){
            Console.WriteLine("Merhaba");
        }
        public void bilgileriSor(){
            Console.WriteLine("Adin ne ve Yasin Kac?");
        }
        public void cevapver(){
            Console.WriteLine("Benim adim " + isim + " ve yasim " +yas);
        }
        public void isimVeYasDuzenle(string isim, int yas){
            this.isim = isim;
            this.yas = yas;
        }
    }
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan();

            i1.isimVeYasDuzenle("Ferhat", 33);
            i2.isimVeYasDuzenle("Zeyd", 0);

            i1.selamVer();
            i2.selamVer();
            i1.bilgileriSor();
            i2.cevapver();
            i2.bilgileriSor();
            i1.cevapver();
        }
    }
}
