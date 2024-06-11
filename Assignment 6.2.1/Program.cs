using System.ComponentModel.Design;

namespace Assignment_6._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implement a stack using an array with push and pop operations.");
            Console.WriteLine("Intended output: stackArray = { 1, 2, 3, 4, 5, 6 }");
            Stack stackArray = new Stack();

            stackArray.Push(6);
            stackArray.Push(5);
            stackArray.Push(4);
            stackArray.Push(3);
            stackArray.Push(2);
            stackArray.Push(1);
            stackArray.PrintStack();
            stackArray.Peek();
            Console.WriteLine("The item popped from stack : {0}", stackArray.Pop());
            stackArray.PrintStack();

        }

    }

    internal class Stack
    {
        static readonly int max = 6;
        int top;
        int[] stackArray = new int[max];

        bool IsEmpty()
        {
            return (top < 0);
        }
        public Stack()
        {
            top = -1;
        }
        internal bool Push(int data)
        {
            if (top >= max)
            {
                Console.WriteLine("Stack Overflow. The most recent value is greater than the allowed amount of elements.");
                return false;
            }
            else
            {
                stackArray[++top] = data; // ++top adds then implements top
                return true;
            }
        }
        internal int Pop() // Pop is "taking an element off the top of the stack." Technically the data is still there, it just makes the pointer at the next element in the stack.
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow. There isn't any data there so you can't pop an empty stack.");
                return 0;
            }
            else
            {
                int value = stackArray[top--];
                return value;
            }
        }
        internal void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("The topmost element of the stack array is: {0}", stackArray[top]);
            }
        }
        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("The stacked array is: ");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stackArray[i]);
                }
            }
        }
       
    }
}
