using System;
using System.Text;

namespace MySuperCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ulong s1 = 1071;
            ulong s2 = 462;

            Calculator ibosCalculator = new Calculator();

            // result = f(10, 15)
            // ulong result1 = ibosCalculator.GCD(s1, s2);

            //int result = ibosCalculator.MultiplyNumbersByAddition(5, 33);
            //Console.WriteLine(result);

            //int checkForPrime = 13;

            //bool asalMi = ibosCalculator.IsPrime(checkForPrime);
            //Console.WriteLine(asalMi == true ? "Evet" : "Hayır");


            string messagge = "Asal olup olmadığını kollayacağımız sayıyı giriniz: ";

            Console.WriteLine(messagge);
            string userInput = Console.ReadLine();

            int userInputAsInteger = Convert.ToInt32(userInput);

            bool asalMi = ibosCalculator.IsPrime(userInputAsInteger);
            Console.WriteLine(asalMi == true ? "Evet" : "Hayır");

            Console.ReadLine();
        }
    }
}