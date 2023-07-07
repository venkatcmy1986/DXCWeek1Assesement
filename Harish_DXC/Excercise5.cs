using System;
namespace ConsoleApp1
{
    public class Stack
    {
        int[] items;
        int top;

        public Stack(int size)
        {
            items = new int[size];
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == items.Length - 1;
        }

        public void Push(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Full!");
                return;
            }

            items[++top] = item;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack underflow");
                return -1;
            }

            return items[top--];
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }

            return items[top];
        }

        public static int Size(Stack stack)
        {
            return stack.top + 1;
        }

        // Method to remove an element
        public static void remove(Stack s, int v)
        {
            Stack temp = new Stack(Size(s));

            while (!s.IsEmpty())
            {
                int element = s.Pop();

                if (element != v)
                {
                    temp.Push(element);
                }
            }

            while (!temp.IsEmpty())
            {
                s.Push(temp.Pop());
            }
        }
        public static void Display(Stack stack)
        {
            if (stack.IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.WriteLine("Stack elements:");
            for (int i = stack.top; i >= 0; i--)
            {
                Console.Write(stack.items[i] + " ");
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Initialize a stack:");
            Stack stk = new Stack(3);
            Console.WriteLine("\nInput some elements onto the stack:");
            stk.Push(45);
            stk.Push(4);
            stk.Push(7);
            stk.Push(89);
            stk.Push(5);
            Stack.Display(stk);
            Console.WriteLine("\nRemove 7 from the said stack:");
            Stack.remove(stk, 30);
            Stack.Display(stk);
            Console.WriteLine("\n\nRemove 50 from the said stack:");
            Stack.remove(stk, 50);
            Stack.Display(stk);
        }
    }
}