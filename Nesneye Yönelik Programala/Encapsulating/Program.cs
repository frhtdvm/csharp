using System;

namespace Encapsulating
{
    class Program
    {
        class Futbolcu
        {
            private int bonservisBedeli;
            public int getBonservisBedeli(){
                return bonservisBedeli;
            }
            public void setBonservisBedeli(int fiyat){
                this.bonservisBedeli = fiyat;
            }
        }
        static void Main(string[] args)
        {
            Futbolcu f1 = new Futbolcu();
            f1.setBonservisBedeli(150000000);

            Console.WriteLine(f1.getBonservisBedeli());
        }
    }
}
