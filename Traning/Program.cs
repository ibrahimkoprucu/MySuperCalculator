using System;

namespace Traning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number1, number2, sum = 0;

            number1 = ReadFromConsoleAsInteger("birinci sayıyı giriniz");
            number2 = ReadFromConsoleAsInteger("ikinci sayıyı giriniz");

            FancyCalculator myFancyCalculator = new FancyCalculator();
            int result1 = myFancyCalculator.SumToGivenNumber(number1);
            int result2 = myFancyCalculator.SumToGivenNumber(number2);

            sum = result2 - result1;

            int mutlakDeger = Math.Abs(sum);
            Console.WriteLine(mutlakDeger);

            Console.ReadKey();
        }

        /// <summary>
        /// Bu method console bir mesaj yazar ve daha sonra kullanıcının girdiği yazıyı tamsayıya çevirip döner.
        /// </summary>
        /// <returns>girilen yazının sayıya çevrilmişini (int)</returns>
        public static int ReadFromConsoleAsInteger(string message)
        {
            Console.WriteLine(message);
            string userInput = Console.ReadLine();

            int userInputAsInt = Convert.ToInt32(userInput);
            return userInputAsInt;
        }
    }
}