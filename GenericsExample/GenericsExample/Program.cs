using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample

    {
        // Problem 1: Swap Two Values
        public class SwapUtil
        {
            public static void Swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;
            }
        }

    // Problem 2: Generic Stack Class
    public class MyStack<T>
    {
        private List<T> stack = new List<T>();

        public void Push(T item) => stack.Add(item);

        public T Pop()
        {
            if (stack.Count == 0) throw new InvalidOperationException("Stack is empty.");
            T item = stack[stack.Count - 1]; // Access last element
            stack.RemoveAt(stack.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (stack.Count == 0) throw new InvalidOperationException("Stack is empty.");
            return stack[stack.Count - 1]; // Access last element
        }
    }


    // Problem 3: Find Maximum in an Array
    public class ArrayUtils
        {
            public static T FindMax<T>(T[] array) where T : IComparable<T>
            {
                if (array == null || array.Length == 0) throw new ArgumentException("Array cannot be empty.");
                T max = array[0];
                foreach (T item in array)
                {
                    if (item.CompareTo(max) > 0) max = item;
                }
                return max;
            }
        }

        // Problem 4: Key-Value Pair Class
        public class KeyValuePair<K, V>
        {
            public K Key { get; }
            public V Value { get; }

            public KeyValuePair(K key, V value)
            {
                Key = key;
                Value = value;
            }

            public void Display() => Console.WriteLine($"Key: {Key}, Value: {Value}");
        }

        // Problem 5: Generic Method for Sorting an Array
        public class SortUtil
        {
            public static void SortArray<T>(T[] array) where T : IComparable<T>
            {
                Array.Sort(array);
            }
        }

        // Problem 6: Count Occurrences in a List
        public class ListUtils
        {
            public static int CountOccurrences<T>(List<T> list, T element)
            {
                int count = 0;
                foreach (T item in list)
                {
                    if (item.Equals(element)) count++;
                }
                return count;
            }
        }

        // Driver Code
        class Program
        {
        static void Main()
        {
            Console.WriteLine("\n------------------------- Swap Elements -------------------------");
            int a = 10, b = 20;
            Console.WriteLine($"Before Swap: a = {a}, b = {b}");
            SwapUtil.Swap(ref a, ref b);
            Console.WriteLine($"After Swap: a = {a}, b = {b}");

            Console.WriteLine("\n------------------------- Generic Stack -------------------------");
            MyStack<string> stack = new MyStack<string>();
            stack.Push("Hello");
            stack.Push("World");
            Console.WriteLine($"Peek: {stack.Peek()}");
            Console.WriteLine($"Pop: {stack.Pop()}");

            Console.WriteLine("\n------------------------- Find Maximum in Array -------------------------");
            int[] numbers = { 3, 7, 2, 9, 5 };
            Console.WriteLine($"Array: {string.Join(", ", numbers)}");
            Console.WriteLine($"Max: {ArrayUtils.FindMax(numbers)}");

            Console.WriteLine("\n------------------------- Key-Value Pair -------------------------");
            KeyValuePair<string, int> kvp = new KeyValuePair<string, int>("Age", 25);
            kvp.Display();

            Console.WriteLine("\n------------------------- Sorting an Array -------------------------");
            double[] values = { 3.1, 1.5, 4.7, 2.2 };
            Console.WriteLine($"Before Sorting: {string.Join(", ", values)}");
            SortUtil.SortArray(values);
            Console.WriteLine($"After Sorting: {string.Join(", ", values)}");

            Console.WriteLine("\n------------------------- Count Occurrences in List -------------------------");
            List<int> numberList = new List<int> { 1, 2, 3, 2, 4, 2 };
            Console.WriteLine($"List: {string.Join(", ", numberList)}");
            Console.WriteLine($"Occurrences of 2: {ListUtils.CountOccurrences(numberList, 2)}");

         
        }
    }
    }


