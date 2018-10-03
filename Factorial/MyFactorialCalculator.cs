namespace Factorial
{
    public class MyFactorialCalculator
    {
        public ulong Calculate(uint x)
        {
            ulong sonuc = 1;
            // başta i şuyken; dığı sürece ; ve her adımda şunu yaptığım halde
            for (uint i = x; i > 0; i--)
            {
                sonuc = sonuc * i;
            }

            return sonuc;
        }

        public ulong f(uint x)
        {
            return x == 0 ? 1 : x * f(x - 1);
        }
    }
}
