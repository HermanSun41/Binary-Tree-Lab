using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Binay_Tree_Lab
{
    internal class BinarySearchTree
    {
        private class Node
        {
            public int value;
            public Node left;
            public Node right;

            public Node(int value) // Fix for CS9113: Constructor properly defined
            {
                this.value = value;
            }
        }

        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void add(int value)
        {
            Node newNode = new Node(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                insertRec(root, newNode);
            }
        }

        public Node findmax() // Fix for CS0050: Changed accessibility of Node to match method
        {
            if (root == null)
            {
                return null;
            }
            else
            {
                return findMaxRec(root);
            }
        }

        private Node findMaxRec(Node current)
        {
            if (current.right == null)
            {
                return current;
            }
            else
            {
                return findMaxRec(current.right);
            }
        }

        private void insertRec(Node current, Node newNode)
        {
            if (newNode.value < current.value)
            {
                if (current.left == null)
                {
                    current.left = newNode;
                }
                else
                {
                    insertRec(current.left, newNode);
                }
            }
            else
            {
                if (current.right == null)
                {
                    current.right = newNode;
                }
                else
                {
                    insertRec(current.right, newNode);
                }
            }
        }
    }
}
