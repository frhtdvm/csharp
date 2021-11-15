using System;

namespace argumanGecisleri
{
    class Program
    {
        static void Main(string[] args)
        {
             int x = 3;
             kupHesapla(ref x);
             //kupHesapla(out x);
             Console.WriteLine(x);
        }
        static void kupHesapla(ref int sayi)
        {
            sayi = sayi * sayi * sayi;
            Console.WriteLine(sayi);
        }
       /*  static void kupHesapla(out int sayi){
            x = 3;
            sayi = sayi * sayi * sayi;
            Console.WriteLine(sayi);
        } */
    }
}
