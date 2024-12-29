namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int strange = -1;
            strange = ~strange;
            Console.WriteLine(strange);

            //var nums = new List<int> { -10, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var nums = new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            Console.WriteLine(LengthOfLIS(nums));
            Console.ReadLine();
        }

        static int LengthOfLIS(List<int> nums)
        {
            // Binary search approach
            int n = nums.Count;
            List<int> ans = new List<int>();

            // Initialize the answer list with the
            // first element of nums
            ans.Add(nums[0]);

            for (int i = 1; i < n; i++)
            {
                if (nums[i] > ans[ans.Count - 1])
                {
                    // If the current number is greater
                    // than the last element of the answer
                    // list, it means we have found a
                    // longer increasing subsequence.
                    // Hence, we append the current number
                    // to the answer list.
                    ans.Add(nums[i]);
                }
                else
                {
                    // If the current number is not
                    // greater than the last element of
                    // the answer list, we perform
                    // a binary search to find the smallest
                    // element in the answer list that
                    // is greater than or equal to the
                    // current number.

                    // The BinarySearch method returns
                    // the index of the first element that is not less than
                    // the current number.
                    int low = ans.BinarySearch(nums[i]);

                    // We update the element at the
                    // found position with the current number.
                    // By doing this, we are maintaining
                    // a sorted order in the answer list.
                    if (low < 0)
                    {
                        low = ~low;
                    }
                    ans[low] = nums[i];
                }
            }

            // The count of the answer list
            // represents the length of the
            // longest increasing subsequence.
            ans.ForEach(x => Console.WriteLine(x));
            return ans.Count;
        }
    }
}
