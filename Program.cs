using System.Collections.Generic;

namespace LinkedListAssignment
{
    class Program
    {
        public static void  Main(String[] args)
        {
            Console.WriteLine("Welcome to the Linked List Program");

            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(70);
            linkedList.Display();
            linkedList.InsertAtPerticlarPosition(2,30);
            Console.WriteLine("***************************");

            Console.WriteLine("30 inserted between 56 and 70");
            linkedList.Display();


        }
    }
}