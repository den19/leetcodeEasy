namespace Memoisation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 10, 22, 9, 33, 21, 50, 41, 60 };
            

            Console.WriteLine(lis(arr));
            Console.ReadLine();
        }

        static int lis(List<int> arr)
        {
            int n = arr.Count;
            


            // Initialize memoization array with -1  
            int[] memo = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                memo[i] = -1;
            }

            int res = 1;
            for (int idx = 1; idx < n; idx++)
                res = Math.Max(res, lisEndingAtIdx(arr, idx, memo));
            return res;
        }

        static int lisEndingAtIdx(List<int> arr, int idx, int[] memo)
        {

            // Base case
            if (idx == 0)
                return 1;

            // Check if the result is already computed
            if (memo[idx] != -1)
                return memo[idx];

            // Consider all elements on left of i,
            // recursively compute LISs ending with 
            // them and consider the largest
            int mx = 1;
            for (int prev = 0; prev < idx; prev++)
                if (arr[prev] < arr[idx])
                    mx = Math.Max(mx, lisEndingAtIdx(arr, prev, memo) + 1);

            // Store the result in the memo array
            memo[idx] = mx;
            return memo[idx];
        }
    }
}
