using System;

namespace do_while_ornegi
{
    class Program
    {

        // ornek restorant menusu
        //1 adana 12.00 TL
        //2 Beyti 22.00 TL
        //3 Salata 7.00 TL
        //4 Corba 8.00 TL
        //5 Icecek 4.00 TL
        //6 Cikis
        static void Main(string[] args)
        {
            int i = 0;
            do
                {
                Console.WriteLine("i = {0}", i);
                    i++;
                    if (i > 5)
                    break;
                } while (i < 10);
        }
    }
}
