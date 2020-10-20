using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List operations");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            int a = list.Search(30);
            list.InsertAtParticularPosition(a + 1, 40);
            list.Display();
            list.DeleteNodeAtParticularPosition(2);
            list.Size();
            //Console.WriteLine("-----------------");
            //list.DeleteNodeAtParticularPosition(0);
            //list.Display();

            //SortingList<int> sortingList = new SortingList<int>();
            //sortingList.AddNode(56);
            //sortingList.AddNode(30);
            //sortingList.AddNode(40);
            //sortingList.AddNode(70);
            //Console.WriteLine("Original list: ");
            //sortingList.DisplaySort();
            //sortingList.SortOrderedList();
            //Console.WriteLine("Final Sorted list: ");
            //sortingList.DisplaySort();

            //list.AddInReverseOrder(70);
            //list.AddInReverseOrder(30);
            //list.AddInReverseOrder(56);
            //list.Display();

        }
    }
}
