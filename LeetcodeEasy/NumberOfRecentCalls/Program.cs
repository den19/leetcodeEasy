namespace NumberOfRecentCalls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class RecentCounter
    {
        private Queue<int> queue;

        public RecentCounter()
        {
            queue = new Queue<int>();
        }

        private int Ping(int t)
        {
            // Добавляем новый запрос
            queue.Enqueue(t);

            // Удаляем устаревшие запросы
            while (queue.Peek() < t - 3000)
            {
                queue.Dequeue();
            }

            // Возвращаем кол-во актуальных запросов
            return queue.Count;
        }
    }
}
