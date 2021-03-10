//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureFundamentals
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Queue<char> queue = new Queue<char>();

//            queue.Enqueue('A');
//            queue.Enqueue('B');
//            queue.Enqueue('C');
//            queue.Enqueue('D');

//            Console.WriteLine("Queue Elements are : ");
//            foreach (var item in queue)
//                Console.Write(item + "\t");

//            Console.WriteLine();

//            char element = (char)queue.Dequeue();
//            Console.WriteLine("Element Dequeued from Queue is : " + element);
//            Console.WriteLine("Total Elements in Queue : " + queue.Count);
//            Console.WriteLine(queue.Count <= 0 ? "Queue is Empty" : "Queue is not Empty");
//            queue.Clear();
//            Console.WriteLine(queue.Count <= 0 ? "Queue is Empty" : "Queue is not Empty");
//            Console.ReadKey();
//        }
//    }
//}
