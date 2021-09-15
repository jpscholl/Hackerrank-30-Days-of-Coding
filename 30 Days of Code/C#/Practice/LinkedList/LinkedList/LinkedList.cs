using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListUS<T>
    {
        // Properties
        Node<T> head;
        int count;

        // Constructors
        //public LinkedList()
        //{
        //    head = null;
        //    count = 0;
        //}

        public LinkedListUS(Node<T> newHead)
        {
            head = newHead;
            count = 1;
        }

        // Methods

        // add
        public void add(T newData)
        {
            Node<T> temp = new Node<T>(newData);
            Node<T> current = head;
            while(current.getNext() != null)
            {
                current = current.getNext();
            }
            current.setNext(temp);
            count++;
        }

        // get
        public T get(int index)
        {
            //if (index <=0 )
            //{
               // return -1;
            //}
            Node<T> current = head;
            for (int i = 1; i < index; i++)
            {
                current = current.getNext();
            }
            return current.getData();
        }
        // size
        public int size()
        {
            return count;
        }

        // isEmpty
        public bool isEmpty()
        {
            return head == null;
        }

        // remove
        public void remove()
        {
            // remove from the back of the list
            Node<T> current = head;
            while (current.getNext().getNext() != null)
            {
                current = current.getNext();
            }
            current.setNext(null);
            count--;
        }
    }
}
