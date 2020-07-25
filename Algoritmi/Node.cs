namespace Algorithms
{
    /// <summary>
    /// A node in the singly linked list.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// The node value as int.
        /// </summary>

        public int Value { get; set; }
        /// <summary>
        /// The next node in the linked list. The last node is null.
        /// </summary>

        public Node Next { get; set; }

        /// <summary>
        /// Constructor of a new node that receive integer value.
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
