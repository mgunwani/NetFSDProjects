//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureFundamentals
//{

//    class Array
//    {
//        private int[] items;
//        private int count;
//        public Array(int length)
//        {
//            items = new int[length];
//        }
//        public void insert(int item)
//        {
//            // If the array is full, resize it.
//            if (items.Length == count)
//            {
//                // Create a new array(twice of size)
//                int[] newItems = new int[count * 2];
//                // Copy all the existing items
//                for (int i = 0; i < count; i++)
//                    newItems[i] = items[i];
//                // Set "items" to this new array
//                items = newItems;
//            }
//            // Add the item at the end
//            items[count] = item;
//            count++;
//        }
//        public void remove(int index)
//        {
//            // Validate the Index:
//            if (index < 0 || index >= count)
//                throw new ArgumentException();
//            // Shift the items to the left to fill the hole
//            // [10,20,30,40,50] // Lets Say Index: 2
//            for (int i = index; i < count; i++)
//                items[i] = items[i + 1];
//            count--;
//        }
//        public void print()
//        {
//            Console.WriteLine("Elements Are: ");
//            for (int i = 0; i < count; i++)
//                Console.WriteLine(items[i]);
//        }
//        public int indexOf(int item)
//        {
//            // If we find item, return the index
//            for (int i = 0; i < count; i++)
//                if (items[i] == item) return i;
//            // Otherwise return -1
//            return -1;
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Array array = new Array(3);
//            array.insert(10);
//            array.insert(20);
//            array.insert(30);
//            array.insert(40);
//            Console.WriteLine(array.indexOf(30) != -1 ? "Element Found" : "Element Not Found");
//            array.print();
//            Console.WriteLine("------------");
//            array.remove(2);
//            array.print();
//            Console.ReadKey();
//        }
//    }
//}
