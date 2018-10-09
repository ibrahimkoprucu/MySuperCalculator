namespace Traning
{
    public class FancyCalculator
    {
        /// <summary>
        /// Bu method bir den başlayarak verilen tamsayıya kadar(x) olan tamsayıların toplamını döner.
        /// </summary>
        /// <param name="x">verilen tamsayı</param>
        /// <returns>toplamı tamsayı(int) tipinde döner</returns>
        public int SumToGivenNumber(int x)
        {
            int sonuc = (x * (x + 1)) / 2;
            return sonuc;
        }

        /// <summary>
        ///  girilen sayiya kadar olan tamsayılardan tek olanlarının toplamını bulur.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int SumOfOddNumbers(int x)
        {
            int sonuc;

            // x = 0
            sonuc = 0;

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 == 1)
                {
                    sonuc = sonuc + i;
                }
            }

            return sonuc;
        }

        public int SumOfEvenNumbers(int x)
        {
            int total = 0;

            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    total = total + i;
                }
            }

            return total;
        }

        public int TwoTimesFour()
        {
            return 2 * 4;
        }
    }
}