using LinkedListDataStructure;
using NUnit.Framework;

namespace LinkedListTest
{
    public class MyList
    {
        /// <summary>
        /// Test the Order of the Node 30->56->70
        /// </summary>
        [Test]
        public void GivenThreeNumbers_WhenLinkedShouldPassTo_LinkedList()
        {
            LinkedList list = new LinkedList();
            Node firstNode = list.Add(30);
            Node secondNode = list.Add(56);
            Node thirdNode = list.Add(70);
            bool result = firstNode.next.Equals(secondNode) && secondNode.next.Equals(thirdNode);
            Assert.AreEqual(result, true);
        }
        /// <summary>
        /// Append a Node 56 after 30 so basically we Implement Append Functionality
        /// </summary>
        [Test]
        public void GiveThreeNumbers_WhenAppendedToLinkedList_ShouldAddedToLast()
        {
            LinkedList list = new LinkedList();
            Node firstNode = list.Add(30);
            Node secondNode = list.Append(56);
            Node thirdNode = list.Add(70);
            bool result = firstNode.next.Equals(secondNode) && secondNode.next.Equals(thirdNode);
            Assert.AreEqual(result, true);

        }
        /// <summary>
        /// Ability to Insert30 Between 56 and 70
        /// </summary>
        [Test]
        public void GivenThreeNumbers_WhenInsertingSecondInBetween_ShouldPassLinkedListResult()
        {

            LinkedList list = new LinkedList();
            Node firstNode = list.Add(30);
            Node secondNode = list.Add(56);
            Node thirdNode = list.Add(70);
            int position = list.SearchElement(56);
            Node fourthNode = list.InsertAtPerticularPosition(position + 1, 40);
            bool result = firstNode.next.Equals(fourthNode) &&
                    fourthNode.next.Equals(secondNode) && secondNode.next.Equals(thirdNode);

            Assert.AreEqual(result, true);
        }
        /// <summary>
        /// Ability to delete the first  element in the LinkedList of sequence 56->30->70
        /// </summary>
        [Test]
        public void GivenThreeFirstElement_WhenDeletedShouldPass_LinkedListResult()
        {
            LinkedList list = new LinkedList();
            Node firstNode = list.Add(30);
            Node secondNode1 = list.Add(56);
            Node thirdNode = list.Add(70);
            list.RemoveFirstNode();
            bool result = secondNode1.next.Equals(thirdNode); 
                    
            Assert.AreEqual(result, true);
        }
        /// <summary>
        /// Ability to delete the last  element in the LinkedList of sequence 56->30->70
        /// </summary>
        [Test]
        public void GivenLastElement_WhenDeletedShouldPass_LinkedListResult()
        {
            LinkedList list = new LinkedList();
            Node firstNode = list.Add(30);
            Node secondNode1 = list.Add(56);
            Node thirdNode = list.Add(70);
            list.RemoveLastNode();

            bool result = firstNode.next.Equals(secondNode1);
            Assert.AreEqual(result, true);
        }
        /// <summary>
        ///  Search the given Node
        /// </summary>
        [Test]
        public void GivenThreeElement_CheckPerticularElement_PresentOrNot()
        {
            LinkedList list = new LinkedList();
            Node firstNode = list.Add(50);
            Node secondNode1 = list.Add(30);
            Node thirdNode = list.Add(70);
            bool checkElement = list.CheckElement(30);
            Assert.AreEqual(true,checkElement);

        }
        /// <summary>
        /// Insert a New Node 40 after the existing Node 30
        /// </summary>
        [Test]
        public void GivenThreeElement_InsertNewNode_AfterNOdeThirty()
        {
            LinkedList list = new LinkedList();
            Node firstNode = list.Add(56);
            Node secondNode = list.Add(30);
            Node thirdNode = list.Add(70);
            int position = list.SearchElement(30);
            Node fourthNode = list.InsertAtPerticularPosition(position + 1, 40);
            bool result = firstNode.next.Equals(fourthNode) &&
                    fourthNode.next.Equals(secondNode) && secondNode.next.Equals(thirdNode);
            Assert.AreEqual(result, true);
        }
        /// <summary>
        /// Remove Middle Element
        /// </summary>
        [Test]
        public void GivenFourNode_RemoveMiddleNode()
        {
            LinkedList list = new LinkedList();
            Node firstNode = list.Add(56);
            Node secondNode1 = list.Add(30);
            Node thirdNode = list.Add(40);
            Node fourthNode = list.Add(70);
            list.RemovePerticularNode(30);
            bool result = firstNode.next.Equals(thirdNode) && thirdNode.next.Equals(fourthNode);
            Assert.AreEqual(result, true);

        }
        /// <summary>
        /// Sort Linked LIst in Increasing Order of Node
        /// </summary>
        [Test]
        public void GivenLinkedList_SortNode_IncreasingOrder()
        {
            LinkedList list = new LinkedList();
            Node firstNode = list.Add(56);
            Node secondNode1 = list.Add(30);
            Node thirdNode = list.Add(70);
            Node fourthNode = list.Add(80);
            list.SortedLinkedList();
            bool result = firstNode.next.Equals(thirdNode) && thirdNode.next.Equals(fourthNode);
            Assert.AreEqual(result, true);

        }
        /// <summary>
        /// Create a Stack of the Three Element 56 30 70
        /// </summary>
        [Test]
        public void CreateStack_OfThreeNode()
        {
            LinkedListStack stack = new LinkedListStack();
            Node firstNode= stack.push(70);
            Node secondNode= stack.push(30);
            Node thirdNode=stack.push(56);
            bool result = firstNode.data.Equals(70) && secondNode.data.Equals(30) && thirdNode.data.Equals(56);
            Assert.AreEqual(result, true);
        }
        /// <summary>
        /// Pop the Element From The stack
        /// </summary>
        [Test]
        public void PopAllElement_FromStack()
        {
            LinkedListStack stack = new LinkedListStack();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.Is_Empty();
            bool result;
            if (stack.top == null)
                result = true;
            else
                result = false;
            Assert.AreEqual(result, true);



        }
    } 
}
