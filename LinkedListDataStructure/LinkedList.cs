using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructure
{
    /// <summary>
    /// This is our LinkList Abstract Operation Class 
    /// </summary>
   public class LinkedList
    {
        internal Node head;
        /// <summary>
        /// Add Node into Link List
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Element Inserted into Linked List"+" " + node.data);
            return node;
        }
        /// <summary>
        /// Display node of The Link List
        /// </summary>
        internal void Display()
        {
            int count = 0;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            Console.Write("Display Linked List Element");
            while (temp != null)
            {
                count++;
                if (count < 3)
                {
                    Console.Write(" " +temp.data + "->");
                    temp = temp.next;
                }
                else
                {
                    Console.Write(" " +temp.data);
                    temp = temp.next;
                }
            }
        }

    }
}
