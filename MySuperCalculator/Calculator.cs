namespace MySuperCalculator
{
    public class Calculator
    {
        // Method finding greatest common divisor.
        public int FindGreatestCommonDivisor(int number1, int number2)
        {
            int ebob = 1;

            // eğer number1, number2'dan büyük ise
            if (number1 > number2)
            {
                // evet ise
                // hiçbirşey yapma
            }
            else
            {
                // büyük sayı küçük sayı yer değiştir
                int temp;
                temp = number1;

                number1 = number2;
                number2 = temp;
            }

            // kaç kere döneceğini söyleyebilir misin ?
            // evet ise for , hayır ise while


            for (int i = number2; i > 1; i--)
            {
                int kalan1 = number1 % i;
                int kalan2 = number2 % i;

                if (kalan1 == 0 & kalan2 == 0)
                {
                    ebob = i;

                    // işim bitti döngüden çıkıyorum.
                    break;
                }
            }

            return ebob;
        }

        // Euclidean algorithm
        // https://www.wikizero.pro/index.php?q=aHR0cHM6Ly9lbi53aWtpcGVkaWEub3JnL3dpa2kvRXVjbGlkZWFuX2FsZ29yaXRobQ
        public ulong GCD(ulong a, ulong b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }
    }
}
