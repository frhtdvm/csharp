using System;

namespace forOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
           // 1 den 1500 e kadar olan sayilarin araligi ve artiran degerleri bulmak

           int kacaKadar, aralik;

           Console.WriteLine("Lütfen Kaca kadar yazdirmak istediginizi giriniz");
           kacaKadar = int.Parse(Console.ReadLine());

           Console.WriteLine("Lütfen yazdirmak istediginiz araliklari giriniz");
           aralik = int.Parse(Console.ReadLine());

           for(int i = 0; i <=kacaKadar; i += aralik)
           {
               Console.WriteLine(i);
           }
        }
    }
}
