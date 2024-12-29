using Microsoft.VisualBasic;

namespace IsSubsequence
{
    internal class Program
    {
        /*Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

        A subsequence of a string is a new string that is formed from the original string 
         * by deleting some(can be none) of the characters without disturbing the relative positions 
         * of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
        */
        static void Main(string[] args)
        {
            Console.WriteLine(IsSubsequence("abc", "anbgc"));
            Console.ReadLine();
        }

        public static bool IsSubsequence(string s, string t)
        {
            int i = 0; // Индекс для строки s
            int j = 0; // Индекс для строки t

            // Проходим по всем символам строки t
            while (j < t.Length && i < s.Length)
            {
                if (s[i] == t[j])
                {
                    i++; // Переход к следующему символу в s
                }
                j++; // Переход к следующему символу в t
            }

            // Проверяем, что достигли конца строки s
            return i == s.Length;
        }
    }
}
