namespace GCDOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abab";
            string s2 = "ab";
            Console.WriteLine("GCD of '{0}' and '{1}': {2}", s1, s2, GcdOfStrings(s1, s2));

            s1 = "abcabcabc";
            s2 = "abcabc";
            Console.WriteLine("GCD of '{0}' and '{1}': {2}", s1, s2, GcdOfStrings(s1, s2));

            Console.ReadLine();
        }

        static string GcdOfStrings(string str1, string str2)
        {
            // Check for empty strings
            if(str1.Length == 0 || str2.Length == 0)
            {
                return str1.Length == 0 ? str2 : str1;
            }

            // If one string is empty, then return it
            if (str1 == str2)
            {
                return str1;
            }

            // Check what string is shorter
            var shorterStr = str1.Length <= str2.Length ? str1 : str2;
            var longerStr = str1.Length > str2.Length ? str1 : str2;

            // Devide longer string to shorter string
            string reminder = longerStr.Substring(shorterStr.Length);

            while (!string.IsNullOrEmpty(reminder))
            {
                // repeat the division
                longerStr = shorterStr;
                shorterStr = reminder;
                reminder = longerStr.Substring(shorterStr.Length);
            }

            return shorterStr;
        }
    }
}
