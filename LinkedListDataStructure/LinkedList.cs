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
        public Node Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    if (temp.data == 56)
                    {
                        temp = temp.next;
                        return node;
                    }
                }
                temp.next = node;
                Console.WriteLine("Element Inserted into Linked List" + " " + node.data);
                
            }
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
        public Node InsertAtPerticularPosition(int position,int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
                return head;
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
                return head;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        return head.next;
                        
                    }
                    head = head.next;
                    return head;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position out of Range");
                    return head;
                }
                Console.WriteLine("Inserted Value is" + head);
                return head;
            }
        }
        public bool CheckElement(int data)
        {
            int count = 0;
            Node node = this.head;
                while(node != null)
                { 
                    if (node.data == data)
                    {
                    return true; ;
                    }
                    node = node.next;
                    count++;
                }
            return false;
        }
        public Node RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
        public Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node newNode = head;
            while(newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }
        public int SearchElement(int data)
        {
            int count = 0;
            Node node = this.head;
            while (node != null)
            {
                if (node.data == data)
                {
                    return count; ;
                }
                node = node.next;
                count++;
            }
            return count;
        }

    }
}
