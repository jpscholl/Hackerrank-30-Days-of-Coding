/*
//  Author: Jonathan Scholl
//  Date: 9/13/2021
//  Exercise: Queuey
//  Description: Hackerrank day 18 tutorial video
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Queuey
{
    public class Queuey<T>
    {
        LinkedList<T> queue;

        //make queue instance
        public Queuey()
        {
            queue = new LinkedList<T>();
        }

        //Checks is queue is empty
        public bool isQueueEmpty()
        {
            return queue.Count < 1;
        }

        public int size()
        {
            return queue.Count;
        }

        //queueing new item
        public void enqueue(T x)
        {
            queue.AddLast(x);
        }

        //dequeueing first item

        //not sure why it was int in video????
        public void dequeue()
        {
            queue.RemoveFirst();
        }

        //Peek at first item
        public T peek()
        {
            return queue.First();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<string> stacky = new Stack<string>();

            stacky.Push("there");
            stacky.Push("hi");

            Console.WriteLine(stacky.Pop() + " ");
            Console.WriteLine("Peek: " + stacky.Peek());
            Console.WriteLine("Count: " + stacky.Count());
            Console.WriteLine(stacky.Pop() + "!");
            Console.WriteLine("Count: " + stacky.Count());

            Queue<string> queuey = new Queue<string>();

            queuey.Enqueue("Hi");
            queuey.Enqueue("There");

            Console.WriteLine(queuey.Peek());
            Console.WriteLine(queuey.Dequeue());
            Console.WriteLine("Count: " + queuey.Count());
            Console.WriteLine(queuey.Peek());
            Console.WriteLine(queuey.Dequeue());


            Queuey<string> stringQueue = new Queuey<string>();

            stringQueue.enqueue("hi");
            stringQueue.enqueue("there!");


            Console.WriteLine(stringQueue.peek());
            stringQueue.dequeue();
            Console.WriteLine(stringQueue.peek());
            stringQueue.dequeue();

            Queuey<int> numberQueue = new Queuey<int>();

            numberQueue.enqueue(5);
            numberQueue.enqueue(7);
            numberQueue.enqueue(6);

            //it doesn't allow me to use RemoveFirst method inside writeline so this was
            //only way I could replicate what happens in the video

            Console.WriteLine("First out: " + numberQueue.peek());
            numberQueue.dequeue();
            Console.WriteLine("Second out: " + numberQueue.peek());
            numberQueue.dequeue();
            Console.WriteLine("Third out: " + numberQueue.peek());
            numberQueue.dequeue();

        }
    }
}
