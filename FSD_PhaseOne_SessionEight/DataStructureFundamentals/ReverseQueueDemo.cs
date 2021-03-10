//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureFundamentals
//{
//    class ReverseQueueDemo
//    {
//        static void reverse(Queue<int> queue)
//        {
//            Stack<int> stack = new Stack<int>();
//            while (!(queue.Count == 0))
//                stack.Push(queue.Dequeue());

//            while (!(stack.Count == 0))
//                queue.Enqueue(stack.Pop());

//            foreach (var item in queue)
//                Console.Write(item + " ");
//        }
//        static void Main(string[] args)
//        {
//            Queue<int> queue = new Queue<int>();
//            queue.Enqueue(10);
//            queue.Enqueue(20);
//            queue.Enqueue(30);
//            reverse(queue);
//            Console.ReadKey();
//        }
//    }
//}
