using System;

namespace degiskenler
{
    class Program
    {
        private const char V = '3';

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            byte b = 5;     //1 byte
            sbyte c = 5;    //1 byte

            short s = 5;     //2 byte
            ushort us = 5;    //2 byte

            Int16 i16 = 2;   //2 byte
            int i = 2;      //4 byte
            Int32 i32 = 2; //4 byte

            uint ui = 2;   //4 byte
            long l = 4;     //8 byte
            ulong ul = 4; //8 byte

            //Reel sayilar
            float f = 5;     //4 byte
            double d = 5;   //8 byte
            decimal de = 5; //16 byte

            char ch = 'a';   //2 byte
            string str = "test"; //sinirsiz

            bool b1 = true; //
            bool b2 = false; //

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 ="x";
            object o2 ='y';
            object o3 = 3; 
            object o4 = 4.3;

            //String degerler

            string str1 = String.Empty;
            str1 = "Ferhat";
            string ad ="ferhat";
            string soyad="Zeyd";
            string tamIsim = ad + " " + soyad;

            //degisken dönüsümleri
            string str20 ="20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            //datime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

        }
    }
}
