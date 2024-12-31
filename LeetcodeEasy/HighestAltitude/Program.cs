namespace HighestAltitude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Altitudes");
            var gain = new[] { 0, -5, -4, 1, 1, -6 };
            Array.ForEach(gain, gain => Console.WriteLine(gain));
            Console.WriteLine($"Highest is: {LargestAltitude(gain)}");
            Console.ReadLine();
        }

        public static int LargestAltitude(int[] gain)
        {
            // Начальная высота равна 0
            int currentHeight = 0;
            // Максимальная высота
            int maxHeight = 0;

            foreach (int g in gain)
            {
                // Прибавляем текущее изменение высоты
                currentHeight += g;

                // Обновляем максимальную высоту
                maxHeight = Math.Max(maxHeight, currentHeight);
            }

            return maxHeight;
        }
    }
}
