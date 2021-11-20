using System;

namespace kapsüllemeOrnek2
{
    class Program
    {
        class BankHesap{
            int bakiye;

            public void paraYatir(int miktar){
                bakiye += miktar;
            }
            public void paraCekme(int miktar){
                bakiye -= miktar;
            }
            public int bakiyeSorgula()
            {
                return bakiye;
            }
        }
        static void Main(string[] args)
        {
            BankHesap b1 = new BankHesap();
            Console.WriteLine(b1.bakiyeSorgula());

            b1.paraYatir(1500);
            Console.WriteLine(b1.bakiyeSorgula());
            b1.paraCekme(750);
            Console.WriteLine(b1.bakiyeSorgula());

        }
    }
}
