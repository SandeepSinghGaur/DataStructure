﻿using System;

namespace LinkedListDataStructure
{
    class Program
    {
        public static bool checkElement;
        /// <summary>
        /// This is Our Main Class from here We call only Method
        /// </summary>
        /// <param name="args"></param>
        /// 
        
        static void Main(string[] args)
        {
            Console.WriteLine("Implement link List Data Structure");
            LinkedList list = new LinkedList();
            Node firstNode=list.Add(56);
            Node secondNode1 = list.Add(30);
           // Node secondNode=list.Append(56);
            Node thirdNode=list.Add(40);
            Node fourthNode = list.Add(70);
            //int position = list.SearchElement(40);
            //Program. checkElement = list.CheckElement(30);
           // Node fifthNode=list.InsertAtPerticularPosition(position + 1, 40);
            list.RemovePerticularNode(30);
            //Console.WriteLine("Check Element Present or not" + " " +checkElement);
            list.Display();
        }
    }
}
