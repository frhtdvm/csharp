using System;

namespace _6_basamakli_sayinin_sayi_degerlerini_toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 523495;

            int birler = sayi % 10;
            int onlar = (sayi % 100)/10;
            int yuzler = (sayi % 1000)/100;
            int binler = (sayi % 10000) / 1000;
            int onbinler = (sayi % 100000) /10000;
            int yuzbinler = sayi / 100000;

            int sayiDegerleri = (birler + onlar+yuzler+binler + onbinler + yuzbinler);

            Console.WriteLine(sayiDegerleri);
        }
    }
}
