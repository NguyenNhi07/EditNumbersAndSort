using System;
using System.Collections.Generic;
namespace EditNumbersAndSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4, 5 };
            Array = RemoveAndSort(Array);
            Console.WriteLine("Mảng sau khi sắp xếp: ");
            foreach (var num in Array)
            {
                if (num == -1)
                {
                    Console.Write("*, ");
                }
                else
                {
                    Console.Write(num + ", ");
                }
            }
        }
        static int[] RemoveAndSort(int[] Array)
        {
            HashSet<int> set = new HashSet<int>();
            List<int> list = new List<int>();
            foreach (int num in Array)
            {
                if (!set.Contains(num))
                {
                    set.Add(num);
                    list.Add(num);
                }
                else
                {
                    list.Add(-1);
                }
            }
            list.Sort((x, y) => x == -1 ? 1 : (y == -1 ? -1 : x.CompareTo(y)));
            return list.ToArray();
        }
    }
}