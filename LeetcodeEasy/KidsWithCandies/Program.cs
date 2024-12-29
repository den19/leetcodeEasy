namespace KidsWithCandies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] candies = { 2, 3, 5, 1, 3 };
            int extraCandies = 3;
            bool[] result = KidsWithCandies(candies, extraCandies);

            Console.WriteLine("Candies array:");
            Array.ForEach(candies, (x) => Console.WriteLine(x));

            Console.WriteLine("Result array:");
            Array.ForEach(result, (x) => Console.WriteLine(x));

            // Результат: [false, false, true, false, false]
            Console.ReadLine();
        }

        public static bool[] KidsWithCandies(int[] candies, int extraCandies)
        {
            // Шаг 1: Найти максимальное количество конфет
            int maxCandies = candies.Max();

            // Шаг 2: Создать результирующий массив
            bool[] result = new bool[candies.Length];

            for (int i = 0; i < candies.Length; i++)
            {
                // Проверяем, может ли ребенок получить достаточно конфет, чтобы стать лидером
                result[i] = candies[i] + extraCandies >= maxCandies;
            }

            return result;
        }
    }
}
