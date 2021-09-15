using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        // Properties
        Node<T> next;
        T data;

        // constructors
        public Node(T newData)
        {
            data = newData;
            next = null;
        }

        public Node(T newData, Node<T> newNext)
        {
            data = newData;
            next = newNext;
        }

        // Getters and Setters
        public T getData()
        {
            return data;
        }
        public Node<T> getNext()
        {
            return next;
        }

        public void setData(T newData)
        {
            data = newData;
        }

        public void setNext(Node<T> newNode)
        {
            next = newNode;
        }
    }
}
