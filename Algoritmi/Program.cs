using System;
using System.Collections;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---------- Binary Search Tree -----------\n");

            BinaryTree bt = new BinaryTree();
            bt.AddNode(10);
            bt.AddNode(4);
            bt.AddNode(13);
            bt.AddNode(5);
            bt.AddNode(12);
            bt.AddNode(3);
            bt.AddNode(15);

            // VISUAL TREEE OUTPUT:
            //          10
            //      4        13
            //   3    5   12    15

            Console.WriteLine("Excpected output: 10 4 3 5 13 12 15");
            Console.Write("Preorder traversal: "); bt.PreorderTraversal(bt.Root);

            Console.WriteLine("\n\nCalling GetNode(3):  ");
            var findNode = bt.GetNode(3);
            Console.WriteLine(findNode != null ? findNode.Data.ToString() : "Required node is not in the tree.");

            Console.WriteLine("\nCalling GetNode(20):  ");
            var findNode2 = bt.GetNode(20);
            Console.WriteLine(findNode2 != null ? findNode2.Data.ToString() : "Required node is not in the tree.");

            Console.WriteLine("\nRemoving the node 15...");
            bt.Remove(15);
            Console.WriteLine("Excpected output: 10 4 3 5 13 12");
            Console.Write("Preorder traversal: "); bt.PreorderTraversal(bt.Root);
            // VISUAL TREEE OUTPUT:
            //          10
            //      4        13
            //   3    5   12

            Console.WriteLine("\n\nRemoving the node 4...");
            bt.Remove(4);
            Console.WriteLine("Excpected output: 10 5 3 13 12");
            Console.Write("Preorder traversal: "); bt.PreorderTraversal(bt.Root);
            // VISUAL TREEE OUTPUT:
            //          10
            //      5        13
            //   3        12

            Console.WriteLine("\n\n---------- Queue -----------");

            // Instantiating the Queue class
            Queue queue = new Queue();

            // Adding the items in queue
            Console.WriteLine($"\nInserting value {1}. Result: {queue.Enqueue(1)}");
            Console.WriteLine($"Inserting value {2}. Result: {queue.Enqueue(2)}");
            Console.WriteLine($"Inserting value {3}. Result: {queue.Enqueue(3)}");
            Console.WriteLine($"Inserting value {4}. Result: {queue.Enqueue(4)}");

            Console.WriteLine("\nExpected items in queue are: 1 2 3 4\n");
            // Printing the items in the queue after calling four enqueue functions
            Console.WriteLine(queue.PrintQueue());

            // Removing two items from the front of queue
            Console.WriteLine($"\nItem removed from the front of queue: {queue.Dequeue()}");
            Console.WriteLine($"\nItem removed from the front of queue: {queue.Dequeue()}");

            // Printing the items in the queue after calling two dequeue functions
            Console.WriteLine("\nExpected items in queue are: 3 4\n");
            Console.WriteLine(queue.PrintQueue());

            // Printing the element at the front of queue
            Console.WriteLine($"\nPeek the first element in queue: {queue.Peek()}");

            // Removing the rest elements from the queue with Dequeue function
            Console.WriteLine($"\nItem removed from the front of queue: {queue.Dequeue()}");
            Console.WriteLine($"\nItem removed from the front of queue: {queue.Dequeue()}");

            // Trying to dequeue from empty queue
            try
            {
                Console.WriteLine("\nCalling the Dequeue() on empty queue... ");
                queue.Dequeue();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n---------- Hashtable -----------\n");

            // Instantiating the HashTable class
            Hashtable ht = new Hashtable();

            // Adding elements to the hash table (key-value pairs)
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, null);
            ht.Add("Code1", "Five");
            ht.Add(5.3, "Six");

            Console.WriteLine($"Total elements in hash table: {ht.Count}");

            // Printing all key-value pairs from hash table
            Console.WriteLine("\nAll key-value pairs added in hash table:");
            foreach (var k in ht.Keys)
            {
                Console.WriteLine($"Key:{k}, Value:{ht[k]}");
            }

            // Printing only values from hash table
            Console.WriteLine("\nAll Values");
            foreach (var k in ht.Keys)
            {
                Console.WriteLine($"Value:{ht[k]}");
            }

            // Remove the item with the specified key
            ht.Remove(5.3); // removes {"Six"}
            Console.WriteLine("\nRemoving item with Key=5.3");

            // Printing all keys from hash table
            Console.WriteLine("\nAll keys contained in hash table:");
            foreach (var k in ht.Keys)
            {
                Console.WriteLine($"Key:{k}");
            }

            // Checking if hash table contains required key or value
            Console.WriteLine("\nCheck if hash table contains...");
            Console.WriteLine($"Contains(1) -> {ht.Contains(1)}"); // returns true
            Console.WriteLine($"ContainsKey(2) -> {ht.ContainsKey(2)}"); // returns true
            Console.WriteLine($"Contains(6) -> {ht.Contains(6)}"); // returns false
            Console.WriteLine($"ContainsValue(\"Six\") -> {ht.ContainsValue("Five")}"); // returns true

            // Removes all elements
            ht.Clear();
            Console.WriteLine($"\nTotal elements after Clear(): {ht.Count}");

            Console.WriteLine("\n ---------------- Jednostruko povezana lista-------------\n");

            // Instance of linked list
            LinkedList list = new LinkedList();

            // Add four different nodes into the list
            list.AddFirst(new Node(1));
            list.AddLast(new Node(5));
            list.AddFirst(new Node(7));
            list.AddLast(new Node(8));
            list.AddLast(new Node(0));

            Console.WriteLine("Expecting next sequence: 7 1 5 8 0");
            // Call the function for printing the current nodes in list
            //list.PrintNodeList(list.Head);
            Console.WriteLine(list.PrintNodeList());

            // Check if the specified value is in the list
            Console.WriteLine(String.Format("\nCheck if number 5 is in sequence? Result: {0}", list.Contains(5) ? "true" : "false"));
            Console.WriteLine(String.Format("\nCheck if number 6 is in sequence? Result: {0}", list.Contains(6) ? "true" : "false"));

            // Remove the first node and print the current list
            list.RemoveFirst();
            Console.WriteLine("\nThe first element was removed. Expecting next sequence: 1 5 8 0");
            Console.WriteLine(list.PrintNodeList());

            // Remove the last node and print the current list
            list.RemoveLast();
            Console.WriteLine("\nThe last element was removed. Expecting next sequence: 1 5 8");
            Console.WriteLine(list.PrintNodeList());

            // Delete all nodes in the list
            list.ClearList();

            Console.WriteLine("\n ---------------- Dvostruko povezana lista-------------\n");

            // Instance of linked list
            DoubleLinkedList double_list = new DoubleLinkedList();

            // Add four different nodes into the list
            double_list.AddFirst(new DoubleNode(1));
            double_list.AddLast(new DoubleNode(5));
            double_list.AddFirst(new DoubleNode(7));
            double_list.AddLast(new DoubleNode(8));
            double_list.AddLast(new DoubleNode(0));

            Console.WriteLine("Expecting next sequence: 7 1 5 8 0");
            // Call the function for printing the current nodes in double linked list
            Console.WriteLine(double_list.PrintNodeList());

            // Check if the specified value is in the double linked list
            Console.WriteLine(String.Format("\nCheck if number 5 is in sequence? Result: {0}", double_list.Contains(5) ? "true" : "false"));
            Console.WriteLine(String.Format("\nCheck if number 6 is in sequence? Result: {0}", double_list.Contains(6) ? "true" : "false"));

            // Remove the first node and print the current double linked list
            double_list.RemoveFirst();
            Console.WriteLine("\nThe first element was removed. Expecting next sequence: 1 5 8 0");
            Console.WriteLine(double_list.PrintNodeList());

            // Remove the last node and print the current double linked list
            double_list.RemoveLast();
            Console.WriteLine("\nThe last element was removed. Expecting next sequence: 1 5 8");
            Console.WriteLine(double_list.PrintNodeList());

            // Delete all nodes in the list
            double_list.ClearList();

            Console.WriteLine("\n-------------- Stack --------------");

            // Instantiating the Stack class
            Stack stack = new Stack();

            // Adding the items in stack
            Console.WriteLine($"\nPushing value {1}. Result: {stack.Push(1)}");
            Console.WriteLine($"Pushing value {2}. Result: {stack.Push(2)}");
            Console.WriteLine($"Pushing value {3}. Result: {stack.Push(3)}");
            Console.WriteLine($"Pushing value {4}. Result: {stack.Push(4)}");

            Console.WriteLine("\nExpected items in stack order are: 4 3 2 1\n");
            // Printing the items in the stack after calling four push functions
            Console.WriteLine(stack.PrintStack());

            // Removing two items from the top
            Console.WriteLine($"\nItem popped from stack: {stack.Pop()}");
            Console.WriteLine($"Item popped from stack: {stack.Pop()}");

            // Printing the items in the stack after calling two pop functions
            Console.WriteLine("\nExpected items in stack order are: 2 1\n");
            Console.WriteLine(stack.PrintStack());

            // Printing the element at the top of the stack
            Console.WriteLine($"\nThe topmost element of Stack is: {stack.Peek()}");

            // Popping all elements from the stack
            Console.WriteLine($"\nItem popped from stack: {stack.Pop()}");
            Console.WriteLine($"\nItem popped from stack: {stack.Pop()}");

            // Trying to pop from empty stack
            try
            {
                Console.WriteLine("\nCalling the Pop() on empty stack... ");
                stack.Pop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}