using System;

namespace Traning
{
    internal class Program
    {
        // girilen sayiya kadar olan tamsayılardan tek olanlarının toplamını bulunuz.
        private static void Main(string[] args)
        {
            Console.WriteLine("lütfen bir pozitif tamsayı giriniz ");

            // y = f(6)
            string userInput = Console.ReadLine();
            int x = Convert.ToInt32(userInput);

            FancyCalculator fancyCalculator;
            fancyCalculator = new FancyCalculator();

            int sumOfOdds = fancyCalculator.SumOfOddNumbers(x);
            int sumOfEvens = fancyCalculator.SumOfEvenNumbers(x);

            int result = fancyCalculator.TwoTimesFour();

            Console.WriteLine("------");
            Console.WriteLine(result);

            Console.WriteLine("------");
            Console.WriteLine(sumOfOdds);
            Console.WriteLine(sumOfEvens);

            Console.ReadLine();
        }
    }
}