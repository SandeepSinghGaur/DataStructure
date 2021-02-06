using System;

namespace LinkedListDataStructure
{
    class Program
    {
        /// <summary>
        /// This is Our Main Class from here We call only Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Implement link List Data Structure");
            LinkedList list = new LinkedList();
            Node firstNode=list.Add(30);
            Node secondNode1 = list.Add(56);
           // Node secondNode=list.Append(56);
            Node thirdNode=list.Add(70);
            //int position = list.SearchElement(56);
            //Node fourthNode=list.InsertAtPerticularPosition(position + 1, 40);
            list.RemoveFirstNode();
            list.Display();
        }
    }
}
