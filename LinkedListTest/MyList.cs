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
        public void Given3NumbersWhenLinkedShouldPassToLinkedList()
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
        public void given3NumbersWhenAppendedToLinkedListShouldAddedToLast()
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
        public void given3NumbersWhenInsertingSecondInBetweenShouldPassLinkedListResult()
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
        public void given3FirstElementWhenDeletedShouldPassLinkedListResult()
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
        public void givenLastElementWhenDeletedShouldPassLinkedListResult()
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
        public void Given3ElementCheckPerticularElementPresentOrNot()
        {
            LinkedList list = new LinkedList();
            Node firstNode = list.Add(30);
            Node secondNode1 = list.Add(56);
            Node thirdNode = list.Add(70);
            bool checkElement = list.CheckElement(30);
            Assert.AreEqual(true,checkElement);

        }
    } 
}
