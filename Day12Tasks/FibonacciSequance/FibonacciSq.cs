using System;

namespace FibonacciSequance
{
    public class FibonacciSq
    {
        /// <summary>
        /// Fibonacci sequence
        /// </summary>
        /// <param name="n"></param>
        public static int[] Sequance(int n)
        {
            int val = Math.Abs(n);
            int[] arr = new int[val];
            arr[0] = 0;
            arr[1] = 1;

            int i = 2;
            while (i < val)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
                i++;
            }  

            if (n < 0)
            {
                for (int j = 0; j < val; j += 2)
                {
                    arr[j] *= -1;
                }
            }

            return arr;
        }
    }
}
