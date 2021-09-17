using System;
using System.Collections.Generic;
class Node
{
	public int data;
	public Node next;
	public Node(int d)
	{
		data = d;
		next = null;
	}

}
class Solution
{
		//Pass Node head to method
		public static Node removeDuplicates(Node head)
		{
			//head becomes currentNode
			var currentNode = head;
			//while the head and next node are empty
			while (currentNode != null && currentNode.next != null)
			{
				//while the next node isn't empty and the data of the current and next node are equal
				while (currentNode.next != null && currentNode.data == currentNode.next.data)
				{
					//the next node is equal to the next node after it (thereby replacing it)
					currentNode.next = currentNode.next.next;
				}
				//otherwise the head equals next node
				currentNode = currentNode.next;
			}
			return head;
		}

	public static Node insert(Node head, int data)
	{
		Node p = new Node(data);


		if (head == null)
			head = p;
		else if (head.next == null)
			head.next = p;
		else
		{
			Node start = head;
			while (start.next != null)
				start = start.next;
			start.next = p;

		}
		return head;
	}
	public static void display(Node head)
	{
		Node start = head;
		while (start != null)
		{
			Console.Write(start.data + " ");
			start = start.next;
		}
	}
	static void Main(String[] args)
	{

		Node head = null;
		int T = Int32.Parse(Console.ReadLine());
		while (T-- > 0)
		{
			int data = Int32.Parse(Console.ReadLine());
			head = insert(head, data);
		}
		head = removeDuplicates(head);
		display(head);
	}
}
