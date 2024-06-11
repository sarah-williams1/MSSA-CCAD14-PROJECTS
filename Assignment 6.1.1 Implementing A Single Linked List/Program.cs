namespace Assignment_6._1._1_Implementing_A_Single_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SingleLinkedList singlyList = new SingleLinkedList();
            singlyList.InsertFront(10);
            singlyList.InsertLast(20);
            Node lastNode = singlyList.GetLastNode();
            singlyList.InsertAfter(lastNode, 30);
            singlyList.ReverseLinkedList();
            
        }
    }
    internal class Node
    {
        internal int data;
        internal Node next; // The next node is of type Node
        public Node(int d) // The constructor
        {
            data = d;
            next = null; // Points to the next node in the linked list.
        }
    }

    internal class SingleLinkedList
    {
        internal Node head; // This class now contains nodes of type Node class. The first node is called head.

        internal void InsertFront(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new(new_data);
            new_node.next = singlyList.head;
            singlyList.head = new_node;
        }

        internal void InsertLast(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }
            Node lastNode = GetLastNode(singlyList);
            lastNode.next = new_node;
        }

        internal Node GetLastNode(SingleLinkedList singlyList)
        {
            Node temp = singlyList.head;
            while (temp.next != null)
            { temp = temp.next; }
            return temp;
        }

        internal void InsertAfter(Node prev_node, int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node cannot be null.");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }

        public void ReverseLinkedList(SingleLinkedList singlyList)
        {
            Node prev = null;
            Node current = singlyList.head;
            Node temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            singlyList.head = prev;
        }
    }

    

}