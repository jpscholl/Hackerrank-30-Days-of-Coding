using System;
class Node
{
    public Node left, right;
    public int data;
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}
class Solution
{
    static int getHeight(Node root)
    {
        return root == null ? -1 : 1 + Math.Max(getHeight(root.left), getHeight(root.right));
    }

    static Node insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else
        {
            Node current;
            if (data <= root.data)
            {
                current = insert(root.left, data);
                root.left = current;
            }
            else
            {
                current = insert(root.right, data);
                root.right = current;
            }
            return root;
        }
    }

    static void Main(String[] args)
    {
        Node root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }
        int height = getHeight(root);
        Console.WriteLine(height);

    }
}
