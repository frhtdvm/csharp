using System;

namespace change_ornegi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[] changes ={2,1,0.50,0.25,0.10,0.5,0.1};
            double price;
            double pay;
            double result;
            int i;

            Console.WriteLine("Give the Price please");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give your Payment Money please");
            pay = Convert.ToDouble(Console.ReadLine());

            result = pay - price;
            for(i = 0; i<=6;i++)
            {
                result = result/changes[i];
                if(result!=0)
                {
                    Console.WriteLine(result.ToString() + Convert.ToString(changes[i]));
                    result%= changes[i];
                }
            }
            

          /*    int[] banknot = { 200,100, 50, 20, 10, 5, 1 };
            int para, adet, i;
            Console.Write("Ödenecek tutar girin : ");
            para = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==========================");
            for (i = 0; i <=6; i++)
            {
                adet = para / banknot[i];
                if(adet!=0)
                Console.WriteLine(adet.ToString() + " adet : " + Convert.ToString(banknot[i] + " TL "));
                para %= banknot[i];
            } */
        }
    }
}
