using System;

namespace matematiksel_Denklem
{
    class Program
    {
        static void Main(string[] args)
        {
            //matematiksel denklem cözme

            /*
            fonksiyon denklemi = f(x) = ax^2 + b + c -> 4x^2+2x+3
            delta = b^2 - 4ac -> 4-4*4*3 = -44 (kökleri bulmak icin kullanilir)
            f(2) f(4)
            */
            double a,b,c,x,sonuc,delta;

            Console.WriteLine("Lütfen fonksiyonun a b c d ve x degerlerini sirasiyla giriniz");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());

            sonuc = a*x*+b*x+c;
            delta = b*b-4*a*c;

            Console.WriteLine("f({0})= " + sonuc + "Delta = " + delta,x);
            
        }
    }
}
