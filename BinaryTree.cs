using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binay_Tree_Lab
{
    internal class BinaryTree
    {
        class Node(int value)
        {
            public int value;
            public Node left;
            public Node right;

        }

        private Node root;

        public BinaryTree()
        {
            root = null;
        }
        public void add(int value)
        {
            Node newNode = new Node(value);    //try
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                addRec(root, newNode);
            }
        }
        public void reheap(int value)
        {
            Node newNode = new Node(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                reheapRec(root, newNode);
            }
        }
        public void Insert(int value)
        {
            Node newNode = new Node(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                InsertRec(root, newNode);
            }
        }
        private void InsertRec(Node current, Node newNode)
        {
            if (newNode.value < current.value)
            {
                if (current.left == null)
                {
                    current.left = newNode;
                }
                else
                {
                    InsertRec(current.left, newNode);
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
                    InsertRec(current.right, newNode);
                }
            }
        }
    }
}
