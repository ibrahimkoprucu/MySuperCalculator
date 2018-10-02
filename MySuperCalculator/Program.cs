using System;

namespace MySuperCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ulong s1 = 1071;
            ulong s2 = 462;

            // #45232332
            Calculator ibosCalculator = new Calculator();

            // result = f(10, 15)
            ulong result = ibosCalculator.GCD(s1, s2);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}