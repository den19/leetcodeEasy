namespace RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            int k = RemoveElement(nums, val);
            Console.WriteLine(k); // Ожидаемый вывод: 1
            for (int i = 0; i < k; i++) // Вывод первых k элементов
            {
                Console.Write(nums[i] + " "); // Ожидается: 2
            }

            Console.ReadLine();
        }

        static int RemoveElement(int[] nums, int val)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i]; // Перемещаем элемент, отличный от val, в начало массива
                    j++;               // Увеличиваем j, чтобы указать на следующую позицию
                }
            }
            return j; // Возвращаем количество элементов, отличных от val
        }
    }
}
