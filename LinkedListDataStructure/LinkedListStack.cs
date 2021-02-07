using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDataStructure
{
  public  class LinkedListStack
    {
        private Node top;
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
    }
}
