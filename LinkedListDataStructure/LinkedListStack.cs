using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructure
{
  public  class LinkedListStack
    {
        public Node top;
        /// <summary>
        /// Initialize top Node By using Constructore
        /// </summary>
        public LinkedListStack()
        {
            this.top = null;
        }
        /// <summary>
        /// Push the Element in the Stack 
        /// </summary>
        /// <param name="data"></param>
        public Node push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("pushed to the Stack" + " " + data);
            return this.top;
        }
        /// <summary>
        /// Display the Element of the Stack
        /// </summary>
        public void DisplayStack()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        /// <summary>
        /// Print  Peek Element of the stack 
        /// </summary>
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("Top Element :" + " " + this.top.data);
        }
        /// <summary>
        /// Pop top Element of the Stack
        /// </summary>
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Deletion is not Possible");
            }
            Console.WriteLine("Value Poped is :" + " " + this.top.data);
            this.top = this.top.next;
        }
        /// <summary>
        /// Remove all Element From the Stack
        /// </summary>
        public void Is_Empty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
