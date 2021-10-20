using System;

namespace dairenin_cevresi
{
    class Program
    {
        static void Main(string[] args)
        {
            //dairenin cevresi ile alanini hesaplayiniz
            //pi sayisi, cevresi ve alani
            const double PI = 3.14;
            double daireninYariCapi;

            Console.WriteLine("Dairenin yari capini giriniz");
            daireninYariCapi = Convert.ToDouble(Console.ReadLine());

            double DaireninCevresi = 2 * PI * daireninYariCapi;
            double DaireninAlani = PI * daireninYariCapi * daireninYariCapi;

            Console.WriteLine("Dairenin Cevresi = " + DaireninCevresi);
            Console.WriteLine("Dairenin Alani = " + DaireninAlani);
            

        }
    }
}
