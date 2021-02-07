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
        /// Append the Node after the Given Node
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Insert a Node Given Position of after the existing Node
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Check Element Present or Not
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Remove First Node of LinkedList
        /// </summary>
        /// <returns></returns>
        public Node RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }
        /// <summary>
        /// Remove Last Node of The Linkedlist
        /// </summary>
        /// <returns></returns>
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
        }/// <summary>
        /// Search a Perticular Node Present Or not
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Reamove a Node From Middle of the LinkedList
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node RemovePerticularNode(int data)
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
            int i = 0;
            while (newNode.next.next != null  && i<=0)
            {
               
                if (newNode.next.data == data)
                {
                    i++;
                    newNode.next = newNode.next.next;
                    break;
                    
                }
            }

            return newNode.next;
        }
        /// <summary>
        /// implemented a Method Which Sort our LinkLIst Element
        /// </summary>
        public void SortedLinkedList()
        {
            if (head == null || head.next == null)
                Console.WriteLine("Linked List already sorted");
            Node newNode = head;
            Node tempNode;
            while (newNode.next != null)
            {
                if (newNode.data > newNode.next.data)
                {
                    tempNode = newNode.next.next; 
                    newNode.next = tempNode;
                    break;

                }
                
            }
        }

    }
}
