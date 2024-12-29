namespace TwoSum
{
    /*Given an array of integers nums and an integer target, return indices of the two numbers
    such that they add up to target.
    You may assume that each input would have exactly one solution, 
    and you may not use the same element twice.
    You can return the answer in any order.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var target = 5;
            var result = TwoSum(nums, target);
            Console.WriteLine($"Target={target}");
            Console.WriteLine("Nums:");
            Array.ForEach(nums, x => { Console.WriteLine(x); });
            Console.WriteLine("Result:");
            Array.ForEach(result, x => { Console.WriteLine(x); });
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
                return new int[0];

            var visited = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var current = nums[i];
                var search = target - current;

                if (visited.ContainsKey(search))
                {
                    return new int[] { visited[search], i };
                }
                else
                {
                    if (!visited.ContainsKey(current))
                    {
                        visited.Add(current, i);
                    }
                }
            }

            return new int[0];
        }
    }
}
