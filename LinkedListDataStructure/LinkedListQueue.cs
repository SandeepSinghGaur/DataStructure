using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructure
{
  public class LinkedListQueue
    {
        Node head = null;
        public Node Enque(int data)
        {
            Node node = new Node(data);
            Node temp = head;
            if (head == null)
            {
                head = node;
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
    }
}
