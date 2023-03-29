namespace LinkedListAssignment
{
    class Program
    {
        public static void  Main(String[] args)
        {
            Console.WriteLine("Welcom to the Linked List Program");
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
            linkedList.Search(30);
        }
    }
}