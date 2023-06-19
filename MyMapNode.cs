using System;
using System.Collections.Generic;

namespace HashTable
{
    public class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public void Add(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, int>> linkedlist = GetLinkedList(position);
            KeyValue<K, int> item = FindItem(linkedlist, key);
            if (item != null)
            {
                item.Value++;
            }
            else
            {
                item = new KeyValue<K, int>() { Key = key, Value = 1 };
                linkedlist.AddLast(item);
            }
        }

        public int GetFrequency(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, int>> linkedlist = GetLinkedList(position);
            KeyValue<K, int> item = FindItem(linkedlist, key);
            return item != null ? item.Value : 0;
        }

        protected LinkedList<KeyValue<K, int>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, int>> linkedlist = items[position];
            if (linkedlist == null)
            {
                linkedlist = new LinkedList<KeyValue<K, int>>();
                items[position] = linkedlist;
            }
            return linkedlist;
        }

        protected KeyValue<K, int> FindItem(LinkedList<KeyValue<K, int>> linkedlist, K key)
        {
            foreach (KeyValue<K, int> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    return item;
                }
            }
            return null;
        }

        public struct KeyValue<K, V>
        {
            public K Key { get; set; }
            public V Value { get; set; }
        }
    }

