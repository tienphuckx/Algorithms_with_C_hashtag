using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnDSAlgorithms
{
    public class Node
    {
        public int element;
        public Node next;
        public Node(int e, Node n)
        {
            element = e;
            next = n;
        }
    }

    class CircularLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public CircularLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int length()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void addLast(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                newest.next = newest;
                head = newest;
            }
            else
            {
                newest.next = tail.next;
                tail.next = newest;
            }
            tail = newest;
            size = size + 1;
        }

        public void display()
        {
            Node p = head;
            int i = 0;
            while (i < length())
            {
                Console.Write(p.element + "-->");
                p = p.next;
                i = i + 1;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            CircularLinkedList l = new CircularLinkedList();
            l.addLast(7);
            l.addLast(4);
            l.addLast(12);
            l.display();
            Console.WriteLine("Size: " + l.length());
            l.addLast(8);
            l.addLast(3);
            l.display();
            Console.WriteLine("Size: " + l.length());
            Console.ReadKey();
        }
    }
}
