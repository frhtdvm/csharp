using System;

namespace metotlardaOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
         toplama(5,6.6);
        }
        static void toplama(int sayi1, int sayi2)
        {
            Console.WriteLine("INT " + (sayi1 + sayi2));
        }
        static void toplama(double sayi1, double sayi2)
        {
            Console.WriteLine("DOUBLE " + (sayi1 + sayi2));
        }
    }
}
