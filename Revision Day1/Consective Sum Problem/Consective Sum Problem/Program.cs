using System;
using System.Collections.Generic;

namespace Consective_Sum_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> i = new List<int> { 1, 4, 4, 4, 0, 4, 3, 3, 1 };
            List<int> res = SumConsecutives(i);
            foreach(int j in res)
            {
                Console.WriteLine(j);
            }
        }
        public static List<int> SumConsecutives(List<int> s)
        {
            List<int> res = new List<int>();
            int data = s[0];
            int sum = 0;
            foreach (int i in s)
            {
                if (i == data)
                {
                    sum += data;
                }
                else
                {
                    res.Add(sum);
                    sum = data = i;
                }
            }
            res.Add(sum);
            return res;
        }
    }
}
