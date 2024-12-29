namespace BinarySearcLastIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int target = 4;

            int found = BinarySearchLastIndex(nums, target);
            Array.ForEach(nums, x => { Console.WriteLine(x); });
            Console.WriteLine($"Target:{target}");
            Console.WriteLine($"Found index:{found}");
        }

        static int BinarySearchLastIndex(int[] arr, int target)
        {
            int low = -1;
            int high = arr.Length - 1;

            while (low < high)
            {
                int mid = low + (high - low + 1) / 2;

                if (arr[mid] >= target)
                {
                    low = mid;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return high >= 0 && arr[high] >= target ? high : -1;
        }
    }
}
