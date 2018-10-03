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

        // Euclid's algorithm
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

        public int MultiplyNumbersByAddition(int x, int y)
        {
            int sum = 0;

            // todo: find a way more performant.
            for (int i = 1; i <= y; i++)
            {
                sum = sum + x;
            }

            return sum;
        }

        public bool IsPrime(int x)
        {
            bool result = true;

            // todo: find a better way to do this.
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}