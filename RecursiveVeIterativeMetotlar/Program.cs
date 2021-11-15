using System;

namespace RecursiveVeIterativeMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(faktoriyel(5));
            Console.WriteLine(iterativeFaktoriyel(5));
        }

        static int faktoriyel(int sayi) 
        {
            if (sayi ==1){
                return 1;
            }
            return sayi * faktoriyel(sayi -1);
        }

        static int iterativeFaktoriyel(int sayi)
        {
            int sonuc = 1;
            while (sayi > 0)
            {
                sonuc *= sayi;
                sayi--;
            }
            return sonuc;
        }
    }
}
