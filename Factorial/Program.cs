using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir tamsayı giriniz:");
            string yazi = Console.ReadLine();


            uint tamsayi = Convert.ToUInt32(yazi);

            if (tamsayi < 0)
            {
                Console.WriteLine("Lütfen sıfırdan büyük bir tamsayı giriniz");
            }
            else
            {
                MyFactorialCalculator myFactorialCalculator = new MyFactorialCalculator();
                ulong sonuc = myFactorialCalculator.Calculate(tamsayi);

                Console.WriteLine(sonuc);
            }

            Console.ReadLine();
        }
    }
}
