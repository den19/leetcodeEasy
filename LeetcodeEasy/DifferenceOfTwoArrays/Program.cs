namespace DifferenceOfTwoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new[] { 1, 2, 3, 3 };
            var nums2 = new[] { 2, 4, 6 };
            Console.WriteLine("The diference between two arrays");
            var result = FindDifference(nums1, nums2);
            Console.ReadLine();
        }

        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> set2 = new HashSet<int>(nums2);

            List<int> result1 = new List<int>();
            List<int> result2 = new List<int>();

            foreach (int num in set1)
            {
                if (!set2.Contains(num))
                {
                    result1.Add(num);
                }
            }

            foreach (int num in set2)
            {
                if (!set1.Contains(num))
                {
                    result2.Add(num);
                }
            }

            return new List<IList<int>>() { result1, result2 };
        }
    }
}
