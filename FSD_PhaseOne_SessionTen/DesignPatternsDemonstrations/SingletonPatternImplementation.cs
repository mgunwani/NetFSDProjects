/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemonstrations
{
    *//*
     	Make your class sealed. Sealed restricts the inheritance
	    Make your constructors private.
     *//*
    sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value : " + counter);
        }
        public void printDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            *//*Singleton s1 = new Singleton();
            s1.printDetails("Hello World");
            s1.printDetails("Hello Everyone");*/

            /*Singleton empObj = new Singleton();
            empObj.printDetails("Employee Details");
            Singleton studObj = new Singleton();
            studObj.printDetails("Student Details");*//*

            Singleton empObj = Singleton.GetInstance;
            empObj.printDetails("Employee Details");

            Singleton studObj = Singleton.GetInstance;
            studObj.printDetails("Student Details");

            Console.ReadKey();
        }
    }
}
*/