namespace LinkedListAssignment
{
    class Program
    {
        public static void  Main(String[] args)
        {
            Console.WriteLine("Welcom to the Linked List Program");
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            Console.WriteLine("Node with data 56 is first Created");

            linkedList.Add(30);
            Console.WriteLine("Next Append 30 to 56");

            linkedList.Add(70);
            Console.WriteLine("Finally Append 70 to 30");

            linkedList.Display();
            Console.WriteLine("LinkedList Sequence: 56->30->70");
        }
    }
}