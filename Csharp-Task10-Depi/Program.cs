using System.Collections;

namespace Csharp_Task10_Depi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =========================
            // Question 1
            // Optimized Bubble Sort
            // =========================

            int[] numbers = { 5, 3, 8, 4, 2, 1 };

            OptimizedBubbleSort(numbers);

            Console.WriteLine("Question 1: Optimized Bubble Sort");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine();


            // =========================
            // Question 2
            // Generic Range<T>
            // =========================

            Range<int> range = new Range<int>(10, 20);

            Console.WriteLine("Question 2: Range<T>");

            Console.WriteLine("Is 15 in range? " + range.IsInRange(15));
            Console.WriteLine("Is 25 in range? " + range.IsInRange(25));
            Console.WriteLine("Length = " + range.Length());

            Console.WriteLine();


            // =========================
            // Question 3
            // Reverse ArrayList
            // =========================

            ArrayList list = new ArrayList()
            {
                1, 2, 3, 4, 5
            };

            ReverseArrayList(list);

            Console.WriteLine("Question 3: Reversed ArrayList");

            foreach (object item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();


            // =========================
            // Question 4
            // Get Even Numbers
            // =========================

            List<int> numberList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8
            };

            List<int> evenNumbers = GetEvenNumbers(numberList);

            Console.WriteLine("Question 4: Even Numbers");

            foreach (int number in evenNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine();


            // =========================
            // Question 5
            // FixedSizeList<T>
            // =========================

            FixedSizeList<int> fixedList = new FixedSizeList<int>(3);

            fixedList.Add(10);
            fixedList.Add(20);
            fixedList.Add(30);

            Console.WriteLine("Question 5: FixedSizeList<T>");

            Console.WriteLine(fixedList.Get(0));
            Console.WriteLine(fixedList.Get(1));
            Console.WriteLine(fixedList.Get(2));

            Console.WriteLine();


            // =========================
            // Question 6
            // First Non-Repeated Character
            // =========================

            string text = "swiss";

            int index = FirstNonRepeatedCharacter(text);

            Console.WriteLine("Question 6: First Non-Repeated Character");

            Console.WriteLine("Index = " + index);
        }


        // ==================================================
        // Question 1
        // Optimized Bubble Sort
        // ==================================================

        static void OptimizedBubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];

                        arr[j] = arr[j + 1];

                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }


        // ==================================================
        // Question 3
        // Reverse ArrayList In-Place
        // ==================================================

        static void ReverseArrayList(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                object temp = list[left];

                list[left] = list[right];

                list[right] = temp;

                left++;
                right--;
            }
        }


        // ==================================================
        // Question 4
        // Get Even Numbers
        // ==================================================

        static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }


        // ==================================================
        // Question 6
        // First Non-Repeated Character
        // ==================================================

        static int FirstNonRepeatedCharacter(string text)
        {
            Dictionary<char, int> frequency =
                new Dictionary<char, int>();


            // Count each character

            foreach (char c in text)
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency[c] = 1;
                }
            }


            // Find first character with frequency = 1

            for (int i = 0; i < text.Length; i++)
            {
                if (frequency[text[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
