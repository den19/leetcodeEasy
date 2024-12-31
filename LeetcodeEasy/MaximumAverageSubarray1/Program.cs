namespace MaximumAverageSubarray1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] { 1, 12, -5, -6, 50, 3 };
            var k = 4;
            Console.WriteLine("Array is:");
            Array.ForEach(nums, x => Console.WriteLine(x));

            Console.WriteLine($"k is: {k}");

            Console.WriteLine($"Maximum average is: {FindMaxAverage(nums, k)}");

            Console.ReadLine();
            
        }

        public static double FindMaxAverage(int[] nums, int k)
        {
            int s = 0;
            for (int i = 0; i < k; ++i)
            {
                s += nums[i];
            }

            int ans = s;
            for (int i = k; i < nums.Length; ++i)
            {
                s += nums[i] - nums[i - k];
                ans = Math.Max(ans, s);
            }
            return ans * 1 / k;
        }
    }
}
