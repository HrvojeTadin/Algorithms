using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    /// <summary>
    /// A node in the double linked list.
    /// </summary>
    public class DoubleNode
    {
        /// <summary>
        /// The node value is integer.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// The next node in the double linked list. The last node has next value null.
        /// </summary>
        public DoubleNode Next { get; set; }

        /// <summary>
        /// The previous node in the double linked list. First node has previous value null.
        /// </summary>
        /// <param name="value"></param> 
        public DoubleNode Previous { get; set; }
        
        /// <summary>
        /// Constructor of a new node that receive integer value.
        /// </summary>
        /// <param name="value"></param>
        public DoubleNode(int value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }
}
