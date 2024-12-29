namespace EuclidGCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 48;
            int b = 18;
            int gcd = EuclidGCD(a, b);
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
            Console.WriteLine($"gcd={gcd}");
        }

        static int EuclidGCD(int a, int b)
        {
            while (b !=0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
