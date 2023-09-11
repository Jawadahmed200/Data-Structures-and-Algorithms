




//Recursion

////MinusByOne(5);
//Console.WriteLine(Factorial(3));

////void MinusByOne(int n)
////{
////    if (n != 0)
////    {
////        MinusByOne(n - 1);
////    }
////    Console.WriteLine("Call : " + n);
////}

//int Factorial(int n)
//{
//    if(n== 0)
//    {
//        return 0;
//    }
//    int fac = 1;
//    for (int i = n; i > 0; i--)
//    {
//        fac = fac * i;
//    }
//    return fac;
//}





//Bubble Sort   

//int[] intArray = { 6, 5, 1, 7, 2, 4 };

//Console.WriteLine(BubbleSort(intArray));

//int[] BubbleSort(int[] array)
//{
//    // hold temporary swap value.
//    int temp = 0;
//    for (int pointer = 0; pointer < array.Length; pointer++)
//    {
//        for (int sort = 0; sort < array.Length-1; sort++)
//        {
//            // First way of swapping with extra variable temp.
//            //if (array[sort] > array[sort+1])
//            //{
//            //    temp = array[sort+1];
//            //    array[sort + 1] = array[sort];
//            //    array[sort]=temp;
//            //}

//            // Second way of swapping without extra variable temp.
//            if (array[sort] > array[sort + 1])
//            {

//                array[sort + 1] = array[sort] + array[sort + 1];
//                array[sort] = array[sort + 1] - array[sort];
//                array[sort + 1] = array[sort + 1] - array[sort];
//            }

//        }
//    }
//    return array;
//}










using DataStructuresandAlgorithms.Hashtable;

Hashtable hashtable=new Hashtable();
hashtable.Set("Jawad", "6586-589-588");
hashtable.Set("Irfan", "7777-589-588");
hashtable.Set("Saqib", "8888-589-588");
hashtable.Set("Imran", "9999-589-588");
hashtable.Set("Rizwan", "4444-589-588");


Console.WriteLine(hashtable.Get("Rizwan"));






//Binary Search Tree

//using DataStructuresandAlgorithms.BinarySearchTree;

//BinarySearchTree binarySearchTree = new BinarySearchTree();
//binarySearchTree.Insert(7, "Jawad");
//binarySearchTree.Insert(23, "Saqib");
//binarySearchTree.Insert(151, "Ali");
//binarySearchTree.Insert(22, "Ali");
//binarySearchTree.Insert(4, "Irfan");
//binarySearchTree.Insert(5, "Irfan");
//binarySearchTree.Insert(1, "Rizwan");

////Console.WriteLine(binarySearchTree.Find(151));
//binarySearchTree.PrintInOrderTreeTraversal();
//Console.WriteLine("------------------------------------");
//binarySearchTree.PrintPreOrderTreeTraversal();
//Console.WriteLine("------------------------------------");
//binarySearchTree.PrintPostOrderTreeTraversal();

//var a = "";


//Binary Search
//int[] intArray = { -22, -15, 2, 7, 20, 30, 54 };
//Console.WriteLine(intArray);

//int BinarySearch(int[] intArray, int value)
//{
//    int start=0;
//    int end = intArray.Length;
//    while (start<end)
//    {
//        int midpoint=(start+end)/2;

//        if (intArray[midpoint] == value)
//        {
//            return midpoint;
//        }
//        else if(intArray[midpoint] < value)
//        {
//            start = midpoint + 1;
//        }
//        else
//        {
//            end = midpoint;
//        }
//    }
//    return -1;
//}

//Console.WriteLine(BinarySearch(intArray, 7));








//using DataStructuresandAlgorithms.Queue;

//Queue queue = new Queue(5);
//queue.Enqueue(1);
//queue.Enqueue(2);
//queue.Enqueue(3);
//queue.Enqueue(4);
//queue.Enqueue(5);

//queue.Dequeue();
//queue.Dequeue();

//var a = "";


//using DataStructuresandAlgorithms.Stack;

//Stack stack = new Stack(5);

//stack.Push("Jawad");
//stack.Push("Jawad 1");
//stack.Push("Jawad 2");
//stack.Push("Jawad 3");
//stack.Push("Jawad 4");

//var isEmpty=stack.IsEmpty();
//var isFull= stack.IsFull();

//Console.WriteLine(stack.Peek());

//stack.Pop();
//isFull = stack.IsFull();
//Console.WriteLine(stack.Peek());

//using DataStructuresandAlgorithms.LinkedList;

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


//var a = "";

//Node nodeA = new Node();
//nodeA.Data = 3;

//Node nodeB = new Node();
//nodeB.Data = 5;

//Node nodeC = new Node();
//nodeC.Data = 500;

//Node nodeD = new Node();
//nodeD.Data = 845;

//nodeA.Next = nodeB;
//nodeB.Next = nodeC;
//nodeC.Next = nodeD;
//nodeD.Next = null;