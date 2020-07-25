using System;

namespace Algoritmi
{
    public class BinaryTree
    {
        public TreeNode Root { get; set; }
        public int Count { get; set; }

        public BinaryTree()
        {
            Count = 0;
            Root = null;
        }

        public void AddNode(int newData)
        {
            TreeNode newNode = new TreeNode(newData);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                TreeNode current = Root;
                TreeNode parent;

                while (true)
                {
                    parent = current;
                    if (newData < current.Data)
                    {
                        current = current.LeftNode;
                        if (current == null)
                        {
                            parent.LeftNode = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.RightNode;
                        if (current == null)
                        {
                            parent.RightNode = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public TreeNode GetNode(int value)
        {
            return FindNode(value, Root);
        }

        private TreeNode FindNode(int value, TreeNode parent)
        {
            if (parent != null)
            {
                if (value == parent.Data) return parent;
                if (value < parent.Data)
                {
                    return FindNode(value, parent.LeftNode);
                }
                else
                {
                    return FindNode(value, parent.RightNode);
                }
            }
            return null;
        }

        public void Remove(int value)
        {
            Remove(Root, value);
        }

        private TreeNode Remove(TreeNode parent, int valueToDelete)
        {
            if (parent == null) return parent;

            if (valueToDelete < parent.Data)
            {
                parent.LeftNode = Remove(parent.LeftNode, valueToDelete);
            }
            else if (valueToDelete > parent.Data)
            {
                parent.RightNode = Remove(parent.RightNode, valueToDelete);
            }
            else
            {
                // node with only one child or no child  
                if (parent.LeftNode == null)
                {
                    return parent.RightNode;
                }
                else if (parent.RightNode == null)
                {
                    return parent.LeftNode;
                }

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                parent.Data = MinValue(parent.RightNode);

                // Delete the inorder successor  
                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        private int MinValue(TreeNode node)
        {
            int minValue = node.Data;

            while (node.LeftNode != null)
            {
                minValue = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minValue;
        }

        public void PreorderTraversal(TreeNode Root)
        {
            if (Root != null)
            {
                Console.Write(Root.Data + " ");    // Visit the root
                PreorderTraversal(Root.LeftNode);  // Traverse the left subtree
                PreorderTraversal(Root.RightNode); // Traverse the right subtree
            }
        }
    }
}