using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Task10_Depi
{
    public class Range<T> where T : IComparable<T>
    {
        private T min;
        private T max;


        // Constructor

        public Range(T min, T max)
        {
            this.min = min;
            this.max = max;
        }


        // Check if value is inside the range

        public bool IsInRange(T value)
        {
            return value.CompareTo(min) >= 0 &&
                   value.CompareTo(max) <= 0;
        }


        // Calculate length

        public double Length()
        {
            dynamic minimum = min;
            dynamic maximum = max;

            return maximum - minimum;
        }
    }
}
