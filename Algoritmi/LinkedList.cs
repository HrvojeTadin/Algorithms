using System.Text;

namespace Algorithms
{
    /// <summary>
    /// Singly linked list class.
    /// </summary>
    public class LinkedList
    {
        /// <summary>
        /// The first node in the list. If the list is empty, head is null.
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// The last node in the list. If the list is empty, tail is null.
        /// </summary>
        public Node Tail { get; set; }

        /// <summary>
        /// The number of items in the list.
        /// </summary>
        public int CountOfNodes { get; set; }

        /// <summary>
        /// Adds the integer value to the start of the list.
        /// </summary>
        /// <param name="node"></param>
        public void AddFirst(Node node)
        {
            Node temp = Head;
            Head = node;
            Head.Next = temp;
            CountOfNodes++;

            if (CountOfNodes == 1) Tail = Head;
        }

        /// <summary>
        /// Add the integer value to the end of the list.
        /// </summary>
        /// <param name="node"></param>
        public void AddLast(Node node)
        {
            if (CountOfNodes == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            CountOfNodes++;
        }

        /// <summary>
        /// Removes all the nodes from the list.
        /// </summary>
        public void ClearList()
        {
            Head = null;
            Tail = null;
            CountOfNodes = 0;
        }
        
        public StringBuilder PrintNodeList()
        {
            Node n = Head;
            StringBuilder Sb = new StringBuilder();

            while (n != null)
            {
                Sb.AppendFormat(n.Value.ToString());
                n = n.Next;
            }
            return Sb;
        }

        /// <summary>
        /// Removes the first node from the list.
        /// </summary>
        public void RemoveFirst()
        {
            if (CountOfNodes != 0)
            {
                Head = Head.Next;
                CountOfNodes--;
                if (CountOfNodes == 0) Tail = null;
            }
        }
          
        /// <summary>
        /// Removes the last node from the list.
        /// </summary>
        public void RemoveLast()
        {
            if (CountOfNodes != 0)
            {
                if (CountOfNodes == 1)
                {
                    Tail = null;
                    Head = null;
                }
                else
                {
                    Node n = Head;
                    while (n.Next != Tail)
                    {
                        n = n.Next;
                    }
                    Tail = n;
                    n.Next = null;
                }
            }
        }

        /// <summary>
        /// Returns true if the list contains the specified item, otherwise returns false.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool Contains(int number)
        {
            Node n = Head;
            while (n.Next != null)
            {
                if (n.Value == number) return true;
                n = n.Next;
            }
            return false;
        }
    }
}