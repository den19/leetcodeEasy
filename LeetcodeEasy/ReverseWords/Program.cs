using System.Text;

namespace ReverseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string");
            string input = "the sky is blue";
            Console.WriteLine(input);
            string output = ReverseWords(input); // "blue is sky the"
            Console.WriteLine("Output string"); 
            Console.WriteLine(output);
        }

        public static string ReverseWords(string s)
        {
            // Удаляем начальные и конечные пробелы
            s = s.Trim();

            // Разбиваем строку на слова
            var words = s.Split(' ');

            // Фильтруем пустые элементы (если были несколько подряд пробелов)
            words = words.Where(word => !string.IsNullOrWhiteSpace(word)).ToArray();

            // Переворачиваем массив слов
            Array.Reverse(words);

            // Формируем новую строку, соединяя слова пробелом
            StringBuilder sb = new StringBuilder();
            foreach (var word in words)
            {
                sb.Append(word).Append(' ');
            }

            // Удаляем последний лишний пробел
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }

            return sb.ToString();
        }
    }
}
