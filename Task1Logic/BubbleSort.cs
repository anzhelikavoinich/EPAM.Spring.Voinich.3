using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logic
{
    /// <summary>
    /// Class sorting the jagged array by bubble sort
    /// </summary>
    public class BubbleSort
    {
        #region Fields and Constants
        /// <summary>
        /// A delegate is used to define the sort order for two
        /// elements in the table.
        /// </summary>
        private delegate bool Order(int[] first, int[] second);
        /// <summary>
        /// Enum of constants used to define the sort order in the table.
        /// </summary>
        public enum SortType
        {
            Ascending,
            Descending
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Delegate method; returns true if sum of first is less than second
        /// </summary>
        private static bool CompareBySum(int[] first, int[] second)
        {
            /* 
             var sum1 = 0;
             var sum2 = 0;
             foreach (var i in first)
                 sum1 += i;
             foreach (var i in second)
                 sum2 += i;
             return sum1 > sum2;*/
            return first.Sum() < second.Sum();
        }
        /// <summary>
        /// Delegate method; returns true if max of first is less than second
        /// </summary>
        private static bool CompareByMax(int[] first, int[] second)
        {
            /*var max1 = 0;
            var max2 = 0;
            foreach (var i in first)
                if(i > max1)
                    max1 = i;
            foreach (var i in second)
                if (i > max2)
                    max2 = i;
            */
            return first.Max() < second.Max();
        }
        /// <summary>
        /// Delegate method; returns true if min of first is less than second
        /// </summary>
        private static bool CompareByMin(int[] first, int[] second)
        {
            return first.Min() < second.Min();
        }
        /// <summary>
        /// Sort elements in an Array object, using the Order
        /// delegate to determine how items should be sorted.
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
        /// <param name="order">Delegate to manage
        /// sort order.</param>
        private static void SortByBubbleSort(int [][] arr, SortType type, Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException("order");
            }
            if (type == SortType.Ascending)
            {
                for (var i = arr.Length - 1; i >= 0; i--)
                {
                    for (var j = 1; j <= i; j++)
                    {
                        if (!order(arr[j - 1], arr[j]))
                        {
                            var temp = arr[j - 1];
                            arr[j - 1] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            else
            {
                for (var i = arr.Length - 1; i >= 0; i--)
                {
                    for (var j = 1; j <= i; j++)
                    {
                        if (order(arr[j - 1], arr[j]))
                        {
                            var temp = arr[j - 1];
                            arr[j - 1] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Public method sorting the jagged array by ascending(descending) sum of rows
        /// </summary>
        /// <param name="arr">jagged array to sort</param>
        /// <param name="type">constant to define the sort order(ascending/descending)</param>
        public static void SortBySums(int [][] arr, SortType type)
        {
            if (arr == null || arr.Length == 0)
                return;
            SortByBubbleSort(arr, type, CompareBySum);

        }

        /// <summary>
        /// Public method sorting the jagged array by ascending(descending) max element of rows
        /// </summary>
        /// <param name="arr">jagged array to sort</param>
        /// <param name="type">constant to define the sort order(ascending/descending)</param>
        public static void SortByMax(int[][] arr, SortType type)
        {
            if(arr == null || arr.Length == 0)
                return;
            SortByBubbleSort(arr, type, CompareByMax);
        }

        /// <summary>
        /// Public method sorting the jagged array by ascending(descending) min element of rows
        /// </summary>
        /// <param name="arr">jagged array to sort</param>
        /// <param name="type">constant to define the sort order(ascending/descending)</param>
        public static void SortByMin(int[][] arr, SortType type)
        {
            if (arr == null || arr.Length == 0)
                return;
            SortByBubbleSort(arr, type, CompareByMin);
        }
        #endregion     
    }
}
