namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Target={121}");
            Console.WriteLine($"Result is:{IsPalindrome}");
            Console.ReadLine();
        }

        public static bool IsPalindrome(int x)
        {
            // Если число отрицательное или оканчивается на 0 (но не само число 0), то оно не может быть палиндромом.
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            // Если число четное, сравниваем все цифры, если нечетное - игнорируем среднюю цифру.
            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
