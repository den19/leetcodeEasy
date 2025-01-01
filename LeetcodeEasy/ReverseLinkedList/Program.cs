namespace ReverseLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var node3 = new ListNode(3, null);
            var node2 = new ListNode(2, node3);
            var node1 = new ListNode(1, node2);
            Console.WriteLine($"node1.val={node1.val}, node1.next={node1.next?.val}");
            Console.WriteLine($"node2.val={node2.val}, node1.next={node2.next?.val}");
            Console.WriteLine($"node3.val={node3.val}, node1.next={node3.next?.val}");
            ListNode.ReverseList(node1);
            Console.WriteLine("Reversed List");
            Console.WriteLine($"node1.val={node1.val}, node1.next={node1.next?.val}");
            Console.WriteLine($"node2.val={node2.val}, node1.next={node2.next?.val}");
            Console.WriteLine($"node3.val={node3.val}, node1.next={node3.next?.val}");
            Console.ReadLine();
        }
    }

    public class ListNode
    {
        public int val { get; set; }
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;

            while (curr != null)
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }

        public ListNode ReverseListRecursion(ListNode head)
        {
            if (head == null)
                return null;

            if (head.next == null)
                return head;

            var next = head.next;
            var rest = ReverseListRecursion(head.next);
            next.next = head;
            head.next = null;

            return rest;
        }
    }
}
