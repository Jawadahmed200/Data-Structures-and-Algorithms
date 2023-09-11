

namespace DataStructuresandAlgorithms.LinkedList
{
    public class LinkList
    {
        public Node? First { get; set; }
        public void InsertFirst(int data)
        {
            //Create new node
            Node newNode = new Node();

            //put the data in new node
            newNode.Data = data;

            //put the old node in next
            newNode.Next = First;

            //make the first the new node
            First = newNode;
        }

        public Node DeleteFirst()
        {
            //assign the temporaray variable
            Node temp = First;
            // assign the next head
            First = First.Next;
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("ITERATING.....");
            Node current = First;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }

        public void InsertLast(int data)
        {
            Node current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;
        }
    }
}


//Write this code in program.cs

//LinkList linkList = new LinkList();
//linkList.InsertFirst(1);
//linkList.InsertFirst(2);
//linkList.InsertFirst(3);
//linkList.InsertFirst(4);

//linkList.DeleteFirst();
//linkList.DeleteFirst();

//linkList.InsertLast(5);
//linkList.InsertLast(6);
//linkList.DisplayList();