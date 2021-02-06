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
            Node secondNode=list.Append(56);
            Node thirdNode = list.Add(70);
            bool result = firstNode.next.Equals(secondNode) && secondNode.next.Equals(thirdNode);
            Assert.AreEqual(result, true);

        }
    }
}