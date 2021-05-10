using System;

namespace Sum_of_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int res= SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 15, 18 }, new int[] { 4, 5 }, new int[] { 12, 60 } });
            int res1 = SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 1, 1 }, new int[] { 0, 0 }, new int[] { 13, 91 } });
            int res2 = SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 15, 7 }, new int[] { 4, 5 }, new int[] { 19, 60 } });
            int res3 = SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 20, 50 }, new int[] { 10, 10 }, new int[] { 50, 20 } });
            int res4 = SumDifferencesBetweenProductsAndLCMs(new int[][] {});
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);
            
        }
        public static int SumDifferencesBetweenProductsAndLCMs(int[][] pairs)
        {
            int upBound0 = pairs.GetUpperBound(0)+1;
          
         
            int result = 0;
            for (int i = 0; i < upBound0; i++)
            {
                int x = pairs[i][0] * pairs[i][1];
                int y = LCM(pairs[i][0], pairs[i][1]);
                result += x - y;
                
            }
           
            return result;
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
