using System;

namespace mini_Oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam,puan=0,dogruCevapSayisi=0,yanlisCevapSayisi=0;
            char devamMi;

            do{
                
            Random rastegele = new Random();
            int sayi1 = rastegele.Next(1,101);
            int sayi2 = rastegele.Next(1,101);
            toplam = sayi1 + sayi2;
            Console.WriteLine("Tutulan sayi 1 = " + sayi1 + "\nTutulan Sayi 2 = " + sayi2);
            Console.WriteLine("Bu Sayilarin Toplami nedir ?");
            int kullaniciToplami = int.Parse(Console.ReadLine());

            if(kullaniciToplami == toplam){
                dogruCevapSayisi++;
                puan += 5;
                Console.WriteLine("Tebrikler bildiniz!");
            }else{
                yanlisCevapSayisi++;
                puan -=2;
                Console.WriteLine("Malesef Bilemediniz");
            }
            Console.WriteLine("Tekrar oynamak istermisiniz ?");
            devamMi = char.Parse(Console.ReadLine());
            
            }while(devamMi == 'e' || devamMi == 'E');

            Console.WriteLine("Dogru Cevap Sayisi  = {0}", dogruCevapSayisi);
            Console.WriteLine("Yanlis Cevap Sayisi = {0}", yanlisCevapSayisi);
            Console.WriteLine("Toplam Puan         = {0}", puan);
            
        }
    }
}
