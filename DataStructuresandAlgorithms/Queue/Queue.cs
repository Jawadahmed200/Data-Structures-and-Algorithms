

namespace DataStructuresandAlgorithms.Queue
{
    public class Queue
    {
        private int MaxSize { get; set; }// sets the  number of elements because this is any arry
        private int[] QueueArray{ get; set; }// Actual array we will store element in.
        private int Front { get; set; }// Index to keep track of front
        private int Rear { get; set; } // Index to keep track of adds
        private int NItems { get; set; } // This will keep track of length

        public Queue(int size)
        {
            MaxSize=size;
            QueueArray=new int[MaxSize];
            Front = 0;
            Rear = -1;
        }


        //Somebody/Item is going at the rear of line
        public void Enqueue(int item)
        {
            Rear++;
            //insert into where the rear is increamented
            QueueArray[Rear] = item;
            NItems++;
        }

        public int Dequeue()
        {
            int temp = QueueArray[Front];
            Front++;
            if (Front == MaxSize)
            {
                Front = 0;
            }
            NItems--;
            return temp;
        }

        public int Peek()
        {
            return QueueArray[Front];
            
        }
    }
}
