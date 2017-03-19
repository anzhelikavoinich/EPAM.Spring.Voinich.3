using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Logic;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array =
            {
                new []{9,8,7},
                new []{10,5,-4},
                new []{4,1,8,9}
            };
            BubbleSort.SortBySums(array, BubbleSort.SortType.Ascending);
            BubbleSort.SortByMax(array, BubbleSort.SortType.Ascending);
            BubbleSort.SortByMin(array, BubbleSort.SortType.Ascending);
            Console.ReadKey();
        }
    }
}
