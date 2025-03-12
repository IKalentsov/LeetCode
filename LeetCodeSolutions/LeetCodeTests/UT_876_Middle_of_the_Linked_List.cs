using LeetCodeSolutions;

namespace LeetCodeTests
{
    public class UT_876_Middle_of_the_Linked_List
    {
        [Test]
        public void Test_MiddleNode_OddNumberOfNodes()
        {
            // Arrange
            var head = CreateListNode (new List<int> { 1, 2, 3, 4, 5 });
            var expected = CreateListNode (new List<int> { 3, 4, 5 });

            // Act
            var result = MiddleOfTheLinkedList.MiddleNode (head);

            // Assert
            Assert.IsTrue (AreEqual (result, expected));
        }

        [Test]
        public void Test_MiddleNode_EvenNumberOfNodes()
        {
            // Arrange
            var head = CreateListNode (new List<int> { 1, 2, 3, 4, 5, 6 });
            var expected = CreateListNode (new List<int> { 4, 5, 6 });

            // Act
            var result = MiddleOfTheLinkedList.MiddleNode (head);

            // Assert
            Assert.IsTrue (AreEqual (result, expected));
        }

        private ListNode CreateListNode(List<int> values)
        {
            if ( values == null || values.Count == 0 )
                return null;

            var head = new ListNode (values[ 0 ]);
            var current = head;

            for ( int i = 1; i < values.Count; i++ )
            {
                current.next = new ListNode (values[ i ]);
                current = current.next;
            }

            return head;
        }

        private bool AreEqual(ListNode node1, ListNode node2)
        {
            while ( node1 != null && node2 != null )
            {
                if ( node1.val != node2.val )
                    return false;

                node1 = node1.next;
                node2 = node2.next;
            }

            return node1 == null && node2 == null;
        }
    }
}
