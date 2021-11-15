using System;

namespace donusDegerineSahipMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
          /*   int toplam;

            toplam = hesapla(5,6);
            Console.WriteLine(toplam);
            Console.WriteLine(hesapla(8,9)); */

            /* string isim ="Zeyd";
            string soyIsim ="Dövme";

            Console.WriteLine(fullNameSoyle(isim, soyIsim)); */
            string kullaniciIfadesi;
            Console.WriteLine("Sizde Anahtar var mi? Varsa VAR yazin");
            kullaniciIfadesi = Console.ReadLine();

            if (anahtarVarmi(kullaniciIfadesi))
            {
                Console.WriteLine("Iceri girebilirsiniz");
            }
            else{
                Console.WriteLine("Iceri giremessin");
            }
        }

        static bool anahtarVarmi(string ifade)
        {
            if (ifade == "Var"){
                return true;
            }
        else
        {
            return false;
        }
        }
        static int hesapla (int sayi1, int sayi2){
            return sayi1 + sayi2;
        }

        static string fullNameSoyle(string isim, string soyIsim){

            return isim + " " + soyIsim;
        }

    }
}
