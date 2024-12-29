namespace CanPlaceFlowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flowerbed = { 1, 0, 0, 0, 1 };
            int n = 1;
            Console.WriteLine("flowerbed");
            Array.ForEach(flowerbed, (x) => Console.WriteLine(x));
            Console.WriteLine(CanPlaceFlowers(flowerbed, n)); // Output: True
        }

        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            for (int i = 0; i < flowerbed.Length && count < n; ++i)
            {
                if (flowerbed[i] == 0 &&
                    (i == 0 || flowerbed[i - 1] == 0) &&
                    (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1;
                    count++;
                }
            }
            return count == n;
        }
    }
}
