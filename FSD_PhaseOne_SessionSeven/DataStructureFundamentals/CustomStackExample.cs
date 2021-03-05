//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureFundamentals
//{
//    class Stack
//    {
//        private int[] items = new int[5];
//        private int count;
//        public void push(int item)
//        {
//            if(count == items.Length)
//                throw new StackOverflowException();
//            items[count++] = item;
//        }
//        public int pop()
//        {
//            if (count == 0)
//                throw new ArgumentException();
//            return items[--count];
//        }
//        public int peek()
//        {
//            if (count == 0)
//                throw new ArgumentException();
//            return (items[count - 1]);
//        }
//        public Boolean isEmpty()
//        {
//            return count == 0;
//        }
//    }
//    class CustomStackExample
//    {
//        public static void Main(string[] args)
//        {
//            Stack stack = new Stack();
//            stack.push(10);
//            stack.push(20);
//            stack.push(30);
//            stack.push(40);
//            Console.WriteLine("Element Popped Out is : " + stack.pop());
//            Console.WriteLine("Element Popped Out is : " + stack.pop());
//            Console.WriteLine("Element Ready to pop is : " + stack.peek());
//            Console.WriteLine(stack.isEmpty() ? "Stack is Empty" : "Stack is not Empty");
//            Console.ReadKey();
//        }
//    }
//}
