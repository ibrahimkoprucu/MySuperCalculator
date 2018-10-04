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
    }
}