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

            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";

            /// Split into array of sub strings.
            string[] para = paragraph.Split(" ");

            ///Creating reference of MyMapNode.
            MyMapNode<int, string> hash = new MyMapNode<int, string>(para.Length);
            int key = 0;
            /// Adds key and values in to Hash table
            foreach (string words in para)
            {
                hash.Add(key, words);
                key++;
            }
            Console.WriteLine("Frequency are :" + hash.GetFrequency("paranoid"));
            /// Removing value
            hash.RemoveValue("avoidable");
            Console.WriteLine("Frequency are :" + hash.GetFrequency("avoidable"));
        }
    }
}
