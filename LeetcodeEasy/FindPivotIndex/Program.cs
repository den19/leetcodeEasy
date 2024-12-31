namespace FindPivotIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] { 1, 7, 3, 6, 5, 6 };
            Array.ForEach(nums, i => { Console.WriteLine(i); });
            Console.WriteLine($"Pivot index is: {FindPivotIndex(nums)}");
            Console.ReadLine();
        }

        public static int FindPivotIndex(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            // Total sum
            int totalSum = 0;
            foreach (int num in nums)
            {
                totalSum += num;
            }

            // Current left sum
            int leftSum = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                // Is current left sum equals right sum
                if (leftSum == totalSum - leftSum - nums[i])
                {
                    return i;
                }

                // Add current element to left sum
                leftSum += nums[i];
            }
            // Else if no condition apply
            return -1;
        }
    }
}
