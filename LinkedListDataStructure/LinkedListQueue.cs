using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructure
{
  public class LinkedListQueue
    {
       public Node head = null;
        /// <summary>
        /// insert Element into Queue
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node Enque(int data)
        {
            Node node = new Node(data);
            Node temp = head;
            if (head == null)
            {
                head = node;
                Console.WriteLine("Inserted into Queue : " + " " + node.data);
                return head;
            }
            
            else
            {
                
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                
            }
            Console.WriteLine("Inserted into Queue : "+" "+ node.data);
            return temp.next;
        }
        /// <summary>
        /// Display Queue Element
        /// </summary>
        public void DisplayQueue()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }   
        }
        /// <summary>
        /// Delete Element From Queue
        /// </summary>
        public void Dqueue()
        {
            if (this.head == null)
                Console.WriteLine("queue is Empty so deletion is not possible");
            else
            {
                while (this.head != null)
                {
                    Console.WriteLine("deleted Element is :" + this.head.data);
                    this.head = this.head.next;
                }
            }
        }
    }
}
