using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnDSAlgorithms
{
    public class Node
    {
        public int element;
        public Node left;
        public Node right;

        public Node(int e, Node l, Node r)
        {
            element = e;
            left = l;
            right = r;
        }
    }
    
    class BinarySearchTree
    {
        Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public Node insert(Node temproot, int e)
        {
            if (temproot != null)
            {
                if (e < temproot.element)
                    temproot.left = insert(temproot.left, e);
                else if (e > temproot.element)
                    temproot.right = insert(temproot.right, e);
            }
            else
            {
                Node n = new Node(e, null, null);
                temproot = n;
            }
            return temproot;
        }

        public void inorder(Node temproot)
        {
            if (temproot != null)
            {
                inorder(temproot.left);
                Console.Write(temproot.element + " ");
                inorder(temproot.right);
            }
        }

        static void Main(string[] args)
        {
            BinarySearchTree B = new BinarySearchTree();
            B.root = B.insert(B.root, 50);
            B.insert(B.root, 30);
            B.insert(B.root, 80);
            B.insert(B.root, 10);
            B.insert(B.root, 40);
            B.insert(B.root, 60);
            B.insert(B.root, 90);
            Console.WriteLine("Inorder Traversal");
            B.inorder(B.root);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
