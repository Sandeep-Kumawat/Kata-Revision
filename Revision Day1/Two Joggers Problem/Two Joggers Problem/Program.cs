using System;

namespace Two_Joggers_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, int> res1 = NbrOfLaps(5, 3);
            Tuple<int, int> res2 = NbrOfLaps(4, 6);
            Tuple<int, int> res3 = NbrOfLaps(5, 5);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
        }
        public static Tuple<int, int> NbrOfLaps(int x, int y)
        {
            int lcm = LCM(x, y);
            int BobLap = lcm / x;
            int CharlesLap = lcm / y;

            return new Tuple<int, int>(BobLap, CharlesLap);
        }
        public static int LCM(int a, int b)
        {
            int max;
            if (a != 0 && b != 0)
            {
                max = (a > b) ? a : b;
                while (true)
                {
                    if (max % a == 0 && max % b == 0)
                    {

                        break;
                    }
                    max++;
                }
                return max;
            }
            else
            {
                return 0;
            }
        }
    }
}
