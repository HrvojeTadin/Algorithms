using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    /// <summary>
    /// Queue class which represent a FIFO (First In First Out) collection of integer items.
    /// </summary>
    public class Queue
    {
        /// <summary>
        /// List that represents queue.
        /// </summary>
        private LinkedList<int> queueList;

        public Queue()
        {
            queueList = new LinkedList<int>();
        }

        /// <summary>
        /// Method that checks if the queue is empty.
        /// </summary>
        /// <returns></returns>
        public bool IsQueueEmpty()
        {
            return queueList.Count == 0;
        }

        /// <summary>
        /// Inserts an item at the end of the queue.
        /// </summary>
        /// <param name="data"></param>
        public bool Enqueue(int data)
        {
            queueList.AddLast(data);
            return true;
        }

        /// <summary>
        /// Removes and returns the item from the front of the queue.
        /// </summary>
        public int Dequeue()
        {
            if (IsQueueEmpty())
            {
                throw new Exception("Queue Underflow - could not remove item from the empty queue!");
            }
            else
            {
                var value = queueList.First.Value;
                queueList.RemoveFirst();
                return value;
            }
        }

        /// <summary>
        /// Returns the item from the front of the queue, without removing it.
        /// </summary>
        public int Peek()
        {
            if (IsQueueEmpty())
            {
                throw new Exception("Queue Underflow - could not peek from the empty queue!");
            }
            else
            {
                return queueList.First.Value;
            }
        }

        /// <summary>
        /// Check if item exists in queue. It returs true when exists, otherwise false.
        /// </summary>
        /// <param name="data"></param>
        public bool Contains(int data)
        {
            if (IsQueueEmpty())
            {
                throw new Exception("Queue Underflow - could not check the existance of element in the empty queue!");
            }
            else
            {
                return queueList.Contains(data);
            }
        }

        /// <summary>
        /// Print all items from the queue.
        /// </summary>
        public StringBuilder PrintQueue()
        {
            if (IsQueueEmpty())
            {
                throw new Exception("Queue Underflow - could not print the elements from the empty queue!");
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Items in the queue are:");
                foreach (var item in queueList)
                {
                    sb.AppendFormat("\n" + item);
                }
                return sb;
            }
        }
    }
}