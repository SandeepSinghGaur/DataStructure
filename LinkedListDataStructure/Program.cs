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
            Node firstNode=list.Add(56);
            Node secondNode=list.Add(30);
            Node thirdNode=list.Add(70);
            list.Display();
        }
    }
}
