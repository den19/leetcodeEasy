namespace GCDOfStrings2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abab";
            string s2 = "ab";
            Console.WriteLine("GCD of '{0}' and '{1}': {2}", s1, s2, GCDOfStringsRecursion(s1, s2));

            s1 = "abcabcabc";
            s2 = "abcabc";
            Console.WriteLine("GCD of '{0}' and '{1}': {2}", s1, s2, GCDOfStringsRecursion(s1, s2));

            Console.ReadLine();
        }

        static string GCDOfStringsRecursion(string s1, string s2)
        {
            // Если одна строка пустая, возвращаем другую строку
            if (string.IsNullOrEmpty(s1))
                return s2;
            if (string.IsNullOrEmpty(s2))
                return s1;

            // Если одна строка является префиксом другой, возвращаем её
            if (s1.StartsWith(s2))
                return s2;
            if (s2.StartsWith(s1))
                return s1;

            // Рекурсивный вызов с уменьшенными строками
            return GCDOfStringsRecursion(s1.Substring(0, Math.Min(s1.Length, s2.Length)),
                       s2.Substring(0, Math.Min(s1.Length, s2.Length)));
        }
    }
}
