using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    /// <summary>
    /// Class that represents stack.
    /// </summary>
    public class Stack
    {
        /// <summary>
        /// MAX = maximum number of items in stack.
        /// </summary>
        static readonly int MAX = 1000;

        /// <summary>
        /// Index of the topmost element in the stack.
        /// </summary>
        int top;

        /// <summary>
        /// List that represents stack.
        /// </summary>
        int[] stack = new int[MAX];


        /// <summary>
        /// Constructor sets up the index value of the topmost element to -1.
        /// </summary>
        public Stack()
        {
            top = -1;
        }

        /// <summary>
        /// Method that checks if the stack is empty.
        /// </summary>
        /// <returns></returns>
        public bool IsStackEmpty()
        {
            return (top < 0);
        }

        /// <summary>
        /// Inserts an object at the top of the Stack. Returns true if successful, otherwise false.
        /// </summary>
        public bool Push(int data)
        {
            if (top >= MAX)
            {
                throw new Exception("Stack Overflow - count not push to a full stack!");
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        /// <summary>
        /// Removes and returns the object from the top of the Stack.
        /// </summary>
        public int Pop()
        {
            if (IsStackEmpty())
            {
                throw new Exception("Stack Underflow - could not pop from empty stack!");
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        /// <summary>
        /// Returns the object from the top of the Stack without removing it.
        /// </summary>
        public int Peek()
        {
            if (IsStackEmpty())
            {
                throw new Exception("Stack Underflow - could not peek from empty stack!");
            }
            else
                return stack[top];
        }

        /// <summary>
        /// Print all items from the stack.
        /// </summary>
        public StringBuilder PrintStack()
        {
            if (IsStackEmpty())
            {
                throw new Exception("Stack Underflow - count not print empty stack!");
            }
            else
            {
                StringBuilder Sb = new StringBuilder();
                Sb.AppendFormat("Items in the Stack are:");
                for (int i = top; i >= 0; i--)
                {
                    Sb.AppendFormat("\n" + stack[i].ToString());
                }
                return Sb;
            }
        }
    }
}