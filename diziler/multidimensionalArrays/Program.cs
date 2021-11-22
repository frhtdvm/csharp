using System;

namespace multidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] sayilar = {{2,3,4},{5,6,7},{8,9,10}};

            //Console.WriteLine(sayilar[1,0]);

            for(int i = 0; i<3; i++)    //buradaki 3 yukaridaki sayilar dizisinin 3 karakter oldugunu belirtiyor (her suslu parantez bir karakter seklinde)
            {
                for(int j = 0; j<3; j++)
                {
                Console.Write(sayilar[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
