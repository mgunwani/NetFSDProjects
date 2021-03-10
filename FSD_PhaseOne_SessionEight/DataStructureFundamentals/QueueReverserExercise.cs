//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureFundamentals
//{
//    class QueueReverserExercise
//    {
//        public static void Reverse(Queue<int> queue, int k)
//        {
//            if (k < 0 || k > queue.Count())
//                throw new ArgumentException();

//            Stack<int> stack = new Stack<int>();

//            // Dequeue the first K elements from the queue
//            // and push them onto the stack
//            for (int i = 0; i < k; i++)
//                stack.Push(queue.Dequeue());

//            // Enqueue the content of the stack at the
//            // back of the queue
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
//            queue.Enqueue(40);
//            queue.Enqueue(50);
//            queue.Enqueue(60);
//            queue.Enqueue(70);
//            queue.Enqueue(80);
//            queue.Enqueue(90);
//            queue.Enqueue(100);
//            Reverse(queue, 5);
//            Console.ReadKey();
//        }
//    }
//}
