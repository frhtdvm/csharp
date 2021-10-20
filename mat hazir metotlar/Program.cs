using System;

namespace mat_hazir_metotlar
{
    class Program
    {
        //math sinifi
        static void Main(string[] args)
        {
            double sayi = 16;

            Console.WriteLine(Math.Pow(sayi, 3));
            Console.WriteLine(Math.Max(sayi,-18));

            double sayi2 = 4.5;
            sayi2 = Math.Ceiling(sayi2);
            Console.WriteLine(sayi2);
            //Console.Writeline(Math.Floor(sayi2)+ " " + Math.Ceiling(sayi2));
        }
    }
}
