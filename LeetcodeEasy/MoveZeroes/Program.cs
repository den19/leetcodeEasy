namespace MoveZeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            MoveZeroes(nums);
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            // Output: 1 3 12 0 0
            Console.ReadLine();
        }

        public static void MoveZeroes(int[] nums)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index++] = nums[i];
                }
            }
            while (index < nums.Length)
            {
                nums[index++] = 0;
            }
        }
    }
}
