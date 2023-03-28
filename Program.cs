using System.Collections.Generic;

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

            Console.WriteLine("LinkedList Sequence: 56->30->70");



            linkedList.RemoveFirstNode();
            linkedList.Display();
            Console.WriteLine("Final Sequence: 30->70");
        }
    }
}