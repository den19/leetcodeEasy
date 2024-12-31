using System.Security.Cryptography.X509Certificates;

namespace UniqueOccurencies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unique Number of Occurencies");
            var arr = new[] { 1, 2, 2, 1, 1, 3 };
            Array.ForEach(arr, x => Console.WriteLine(x));
            var result = UniqueOccurrencies(arr);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static bool UniqueOccurrencies(int[] arr)
        {
            // Словарь для подсчёта частот
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            // Заполним словарь количеством вхождений каждого элемента
            foreach (var num in arr)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            // Поместим все значения частот в новое множество
            HashSet<int> frequencies = new HashSet<int>(frequencyMap.Values);

            // Сравним размер словаря и множества
            return frequencyMap.Count == frequencies.Count;
        }

    }
}
