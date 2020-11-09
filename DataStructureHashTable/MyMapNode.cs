using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureHashTable
{
    public class MyMapNode<K, V>
    {
        /// Variable
        public readonly int size;
        public readonly LinkedList<keyValue<K, V>>[] items;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyMapNode{K, V}"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<keyValue<K, V>>[size];
        }

        /// <summary>
        /// Gets and sets the values.
        /// </summary>
        /// <typeparam name="k"></typeparam>
        /// <typeparam name="v"></typeparam>
        public struct keyValue<k, v>
        {
            public k key { get; set; }
            public v value { get; set; }
        }

        /// <summary>
        /// Gets the linkedlist.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns></returns>
        protected LinkedList<keyValue<K, V>> GetLinkedlist(int position)
        {
            LinkedList<keyValue<K, V>> linkedLlist = items[position];
            if (linkedLlist == null)
            {
                linkedLlist = new LinkedList<keyValue<K, V>>();
                items[position] = linkedLlist;
            }
            return linkedLlist;
        }

        /// <summary>
        /// Gets the array postion.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        protected int GetArrayPostion(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        /// <summary>
        /// Gets the value provided by key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public V Get(K key)
        {
            int position = GetArrayPostion(key);
            LinkedList<keyValue<K, V>> linkedlist = GetLinkedlist(position);
            foreach (keyValue<K, V> item in linkedlist)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default;
        }

        /// <summary>
        /// Adds the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void Add(K key, V value)
        {
            int position = GetArrayPostion(key);
            LinkedList<keyValue<K, V>> linkedlist = GetLinkedlist(position);

            keyValue<K, V> item = new keyValue<K, V>() { key = key, value = value };
            linkedlist.AddLast(item);
        }

        /// <summary>
        /// Removes the value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public void RemoveValue(V value)
        {
            /// Iterating to get key in list
            foreach (LinkedList<keyValue<K, V>> list in items)
            {
                if (list == null)
                    continue;

                /// iterating to get value in list
                foreach (keyValue<K, V> obj in list)
                {
                    if (obj.Equals(null))
                        continue;
                    if (obj.value.Equals(value))
                    {
                        /// calling method to remove key
                        Remove(obj.key);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Removes the value provided by key.
        /// </summary>
        /// <param name="key">The key.</param>
        public void Remove(K key)
        {
            int position = GetArrayPostion(key);
            LinkedList<keyValue<K, V>> linkedlist = GetLinkedlist(position);

            bool itemFound = false;

            keyValue<K, V> foundItem = default(keyValue<K, V>);
            foreach (keyValue<K, V> item in linkedlist)
            {
                if (item.key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedlist.Remove(foundItem);
                Console.WriteLine("Element was deleted");
            }
        }

        /// <summary>
        /// Gets the frequency.
        /// </summary>
        /// <param name="value">The value.</param>
        public int GetFrequency(V value)
        {
            int count = 0;
            /// To get the key value of each item
            foreach (LinkedList<keyValue<K, V>> list in items)
            {
                if (list == null)
                    continue;

                /// To get the value of the item 
                foreach (keyValue<K, V> obj in list)
                {
                    if (obj.Equals(null))
                        continue;
                    if (obj.value.Equals(value))
                        count++;
                }
            }
            return count;
        }
    }
}
