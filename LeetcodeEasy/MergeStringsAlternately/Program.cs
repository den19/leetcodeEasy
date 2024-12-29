namespace MergeStringsAlternately
{
    /*
    Анализ сложности:
    Временная сложность : O(max(L1,L2)), где L1 и L2 — длины строки 1 и строки 2 соответственно.
    Вспомогательное пространство : O(L1+L2), где L1 и L2 — длины строки 1 и строки 2 соответственно.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = "geeks";
            var s2 = "forgeeks";
            Console.WriteLine(Merge(s1, s2));
            Console.ReadLine();
        }

        // Function for alternatively merging two strings  
        static string Merge(string s1, string s2)
        {
            // To store the final string  
            string result = "";

            // For every index in the strings  
            for (int i = 0; i < s1.Length || i < s2.Length; i++)
            {

                // First choose the ith character of the  
                // first string if it exists  
                if (i < s1.Length)
                    result += s1[i];

                // Then choose the ith character of the  
                // second string if it exists  
                if (i < s2.Length)
                    result += s2[i];
            }
            return result;
        }
    }
}
