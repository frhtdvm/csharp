using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double kareninBirKenari, dikdortgenUzunKenar, dikdortgenKisaKenar;
            
            Console.WriteLine("karenin bir kenarini giriniz");

            kareninBirKenari = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin uzun ve kisa kenarlarini sirasiyla giriniz");
            dikdortgenUzunKenar = Convert.ToDouble(Console.ReadLine());
            dikdortgenKisaKenar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Karenin cevresi = " + (4* kareninBirKenari) + "Karenin Alani =" + (kareninBirKenari * 2));

            Console.WriteLine("Dikdörtgenin cevresi = " + (2*(dikdortgenKisaKenar + dikdortgenUzunKenar)));
            Console.WriteLine("Dikdörtgenin Alani = " + (dikdortgenUzunKenar * dikdortgenKisaKenar));
        }
    }
}
