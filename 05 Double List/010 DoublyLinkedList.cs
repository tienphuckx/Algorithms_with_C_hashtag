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
        public Node prev;

        public Node(int e, Node n, Node p)
        {
            element = e;
            next = n;
            prev = p;
        }
    }

    class DoublyLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public DoublyLinkedList()
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
            Node newest = new Node(e, null, null);
            if (isEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                tail.next = newest;
                newest.prev = tail;
                tail = newest;
            }
            size = size + 1;
        }

        public void addFirst(int e)
        {
            Node newest = new Node(e, null, null);
            if (isEmpty())
            {
                head = newest;
                tail = newest;
            }
            else
            {
                newest.next = head;
                head.prev = newest;
                head = newest;
            }
            size = size + 1;
        }

        public void addAny(int e, int position)
        {
            if (position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            Node newest = new Node(e, null, null);
            Node p = head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i = i + 1;
            }
            newest.next = p.next;
            p.next.prev = newest;
            p.next = newest;
            newest.prev = p;
            size = size + 1;
        }

        public void display()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.element + "-->");
                p = p.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            DoublyLinkedList l = new DoublyLinkedList();
            l.addLast(7);
            l.addLast(4);
            l.addLast(12);
            l.addLast(8);
            l.addLast(3);
            l.display();
            Console.WriteLine("Size: " + l.length());
            l.addAny(20, 3);
            l.display();
            Console.WriteLine("Size: " + l.length());

            Console.ReadKey();
        }
    }
}
