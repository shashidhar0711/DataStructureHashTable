using System;

namespace DataStructureHashTable
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Hashmap.");
            /// Create a  reference of MyMapNode
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);

            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            hash.GetFrequency("To");

            string hashFive = hash.Get("5");
            Console.WriteLine("5th index value is: " + hashFive);

            string hashTwo = hash.Get("2");
            Console.WriteLine("2nd index value is: " + hashTwo);
        }
    }
}
