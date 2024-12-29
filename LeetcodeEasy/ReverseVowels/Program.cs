namespace ReverseVowels
{
    internal class Program
    {
        private static readonly HashSet<char> vowels = new HashSet<char>(new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' });

        static void Main(string[] args)
        {
            string input = "leetcode";
            string output = ReverseVowels(input); // "leotcede"
            Console.WriteLine("Input is");
            Console.WriteLine(input);
            Console.WriteLine("Output is");
            Console.WriteLine(output);
        }

        public static string ReverseVowels(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            char[] chars = s.ToCharArray();
            int left = 0, right = s.Length - 1;

            while (left < right)
            {
                while (left < right && !vowels.Contains(chars[left]))
                    left++;
                while (left < right && !vowels.Contains(chars[right]))
                    right--;

                if (left < right)
                {
                    char temp = chars[left];
                    chars[left++] = chars[right];
                    chars[right--] = temp;
                }
            }

            return new string(chars);
        }
    }
}
