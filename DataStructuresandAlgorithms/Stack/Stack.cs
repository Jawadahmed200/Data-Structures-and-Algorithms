

using System.Security.Principal;

namespace DataStructuresandAlgorithms.Stack
{
    public class Stack
    {
        public int MaxSixe { get; set; }
        public string[] StackArray { get; set; }
        public int Top { get; set; }

        public Stack(int size)
        {
            this.MaxSixe = size; 
            this.StackArray=new string[MaxSixe];

            //we give top -1 because array is 0 index. if we dont it will skip first element.
            this.Top = -1;
        }

        public void Push(string item)
        {
            Top++;
            if(Top == this.MaxSixe)
            {
                throw new Exception("Stack is full");
            }
            this.StackArray[Top] = item;
        }

        public string Pop()
        {
            var oldTop = Top;
            Top--;
            return StackArray[oldTop];
        }

        public string Peek()
        {
            return StackArray[Top];
        }

        public bool IsEmpty()
        {
            return Top == 0;
        }

        public bool IsFull()
        {
            return MaxSixe - 1 == Top;
        }

    }
}
