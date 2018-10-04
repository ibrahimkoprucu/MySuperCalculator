using System;

namespace Traning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // girilen sayiya kadar olan tamsayılardan tek olanlarının toplamını bulunuz.
            int x, sonuc = 0;
            string userInput;

            Console.WriteLine("lütfen bir pozitif tamsayı giriniz ");

            // y = f(6)
            userInput = Console.ReadLine();
            x = Convert.ToInt32(userInput);

            FancyCalculator fancyCalculator;
            fancyCalculator = new FancyCalculator(); 

            sonuc = fancyCalculator.SumOfOddNumbers(x);

            Console.WriteLine("------");
            Console.WriteLine(sonuc);
        }
    }
}