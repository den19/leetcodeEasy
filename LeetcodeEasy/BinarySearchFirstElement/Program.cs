namespace BinarySearchFirstElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            Func<int, bool> target = (int x) => x == 4;

            int found = BinarySearchFirstIndexDelegate(nums, target);
            Array.ForEach(nums, x => { Console.WriteLine(x); });
            Console.WriteLine($"Target:{target}");
            Console.WriteLine($"Found index:{found}");
        }

        static int BinarySearchFirstIndexDelegate(int[] arr, Func<int, bool> condition)
        {
            int low = 0;
            int high = arr.Length;

            while (low < high)
            {
                int mid = low + (high - low) / 2;

                if (condition(arr[mid]))
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return low < arr.Length && condition(arr[low]) ? low : -1;
        }
    }
}
