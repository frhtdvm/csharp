using System;

namespace foreachNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] sayilar = {2,5,3,8,9,10,12,25};
            int toplam = 0;

            foreach (var item in sayilar)
            {
                toplam += item;
            }
                Console.WriteLine(toplam);

        }
    }
}
