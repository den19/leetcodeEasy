namespace BinarySearchClassic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int target = 2;
            int found = BinarySearch(nums, target);
            Array.ForEach(nums, x => { Console.WriteLine(x); });
            Console.WriteLine($"Target:{target}");
            Console.WriteLine($"Found index:{found}");
        }

        static int BinarySearch(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }
    }
}
