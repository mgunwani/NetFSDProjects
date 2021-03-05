//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureFundamentals
//{
    

//    class LinkedList
//    {
//        private class Node  
//        {
//            public int value;
//            public Node next;
//            public Node(int item)
//            {
//                this.value = item;
//            }
//        }
//        Node first;
//        Node last;
//        public void addLast(int item)
//        {
//            var node = new Node(item);
//            if (first == null)
//                first = last = node;
//            else
//            {
//                last.next = node;
//                last = node;
//            }
//        }
//        public void addFirst(int item)
//        {
//            var node = new Node(15);
//            if (first == null)
//                first = last = node;
//            else
//            {
//                node.next = first;
//                first = node;
//            }
//        }
//        public int indexOf(int item)
//        {
//            // If Element Found, return the index
//            int index = 0;
//            var current = first;
//            while(current!= null)
//            {
//                if (current.value == item) return index;
//                current = current.next;
//                index++;
//            }
//            // Otherwise, return -1
//            return -1;
//        }
//        public bool contains(int item)
//        {
//            return indexOf(item) != -1;
//        }

//        // RemoveFirst

//        // RemoveLast


//    }
//    class CustomLinkedListDemo
//    {
//        public static void Main(string[] args)
//        {
//            LinkedList list = new LinkedList();
//            list.addLast(10);
//            list.addLast(20);
//            list.addLast(30);
//            list.addFirst(15);
//            Console.WriteLine("Index : " + list.indexOf(200));
//            Console.WriteLine("Index : " + list.indexOf(200));
//            Console.WriteLine("Index : " + list.contains(20));
//            Console.ReadKey();
//        }
//    }
//}
