using System;

namespace BinarySearch
{
    public static class BinSearch
    {
        /// <summary>
        /// Binary search method
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="obj"></param>
        /// <param name="comparer"></param>
        /// <returns>Index of object</returns>
        public static int Search<T>(this T[] arr, T obj, Comparison<T> comparer)
        {
            if (arr.Length == 0)
            {
                throw new Exception("Array is empty");
            }

            if (comparer == null || arr == null)
            {
                throw new ArgumentNullException("Array or comparer is null");
            }

            int index;
            int left = 0;
            int right = arr.Length;

            while (true)
            {
                index = (left + right) / 2;
                if (arr[index].Equals(obj))
                {
                    return index;
                }

                if (left == right)
                {
                    return -1;
                }
                else if (comparer(arr[index], obj) > 0)
                {
                    right = index;
                }
                else if (comparer(arr[index], obj) < 0)
                {
                    left = index;
                }
            }
        }
    }
}
