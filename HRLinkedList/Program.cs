using System;
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

    public static Node insert(Node head, int data)
    {
        //Complete this method
        //if head is null, set next to null and data to data
        if (head == null)
        {
           return new Node(data);
        }
        else
        {
           var rNode = new Node(data);
            head.next = rNode;
            return head;
        }
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
        display(head);
    }
}
