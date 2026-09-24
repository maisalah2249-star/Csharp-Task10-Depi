using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Task10_Depi
{
    public class FixedSizeList<T>
    {
        private T[] items;
        private int count;


        // Constructor

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException(
                    "Capacity must be greater than zero.");
            }

            items = new T[capacity];

            count = 0;
        }


        // Add element

        public void Add(T item)
        {
            if (count >= items.Length)
            {
                throw new InvalidOperationException(
                    "The list is full.");
            }

            items[count] = item;

            count++;
        }


        // Get element

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException(
                    "Invalid index.");
            }

            return items[index];
        }
    }
}
