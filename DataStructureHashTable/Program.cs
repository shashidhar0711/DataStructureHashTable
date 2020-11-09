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
            Console.WriteLine("Welcome to Hashmap.");

            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";

            /// Split into array of sub strings.
            string[] para = paragraph.Split(" ");

            /// Create a reference of MyMapNode
            MyMapNode<int, string> hash = new MyMapNode<int, string>(para.Length);
            int key = 0;

            /// iterating a paragraph
            /// adds key and value in to hash.
            foreach (string words in para)
            {
                hash.Add(key, words);
                key++;
            }
            Console.WriteLine("Frequency are :"+hash.GetFrequency("paranoid"));
        }
    }
}
