using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve Islemli atama

            int x = 3;
            int y = 2;
            y = y+2;
            y += 2;

            Console.WriteLine("y");
            y +=2;
            Console.WriteLine("y");
            y/=1;
            Console.WriteLine("y");
            x *= 2;
            Console.WriteLine("x");

            //Mantiksal operatörler
            bool isSuccess = true;
            bool isComplete = false;
            
            if(isSuccess && isComplete)
                Console.WriteLine("Perfect!");
            if(isSuccess || isComplete)
                Console.WriteLine("Great!");
            if(isSuccess && !isComplete)
                Console.WriteLine("Fine!");

            //iliskisel Operatörler
            int a = 3;
            int b = 4;
            bool sonuc = a<b;

            Console.WriteLine("sonuc");
            sonuc = a>b;
            Console.WriteLine("sonuc");
            sonuc = a>=b;
            Console.WriteLine("sonuc");
            sonuc = a<=b;
            Console.WriteLine("sonuc");
            sonuc = a<b;
            Console.WriteLine("sonuc");
            sonuc = a==b;
            Console.WriteLine("sonuc");
            sonuc = a!=b;
        }
    }
}
