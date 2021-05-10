using System;
using System.Collections.Generic;
using System.Linq;

namespace Delete_Occurrences_of_an_element
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);
            foreach(int i in res)
            {
                Console.WriteLine(i);
            }
        }
        public static int[] DeleteNth(int[] arr, int x)
        {

            List<int> res = new List<int>();
            foreach (int i in arr)
            {
                if (res.Count(j => j == i) < x)
                {
                    res.Add(i);
                }
            }
            return res.ToArray();
        }
    }
}
