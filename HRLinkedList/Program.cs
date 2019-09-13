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
        var newNode = new Node(data);
        var currNode = head;
        

        if (head == null)
        {
           return new Node(data);
        }
        //get the last node in LL
        // insert(currNode.next, data);
        while (currNode.next != null)
        {
            //not last node
            currNode = currNode.next;
        }
        //after the while loop, then currNode.next should be null
        currNode.next = newNode;   //why does this also manipulate head?
        //currNode = head;
        //return currNode;
        //head.next = newNode;    //doesn't work
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
        display(head);
    }
}
