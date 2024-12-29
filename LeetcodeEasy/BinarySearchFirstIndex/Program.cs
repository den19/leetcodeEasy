namespace BinarySearchFirstIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int target = 4;

            int found = BinarySearchFirstIndex(nums, target);
            Array.ForEach(nums, x => { Console.WriteLine(x); });
            Console.WriteLine($"Target:{target}");
            Console.WriteLine($"Found index:{found}");
        }

        static int BinarySearchFirstIndex(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length;

            while (low < high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] >= target)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return low < arr.Length && arr[low] >= target ? low : -1;
        }
    }
}
