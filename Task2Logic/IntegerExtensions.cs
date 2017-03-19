using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Logic
{
    /// <summary>
    /// Static class contains extension method
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// The extension method converting integer numbers to hexadecimal notation
        /// </summary>
        /// <param name="num">The first parameter takes the "this" modifier
        /// and specifies the type for which the method is defined</param>
        public static string GetHexadecimalNotation(this int num)
        {
            var alf = "0123456789ABСDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = null;
            var cifr = new List<int>();
            while (num != 0)
            {
                cifr.Add(num % 16);
                num /= 16;
            }
            for (var i = cifr.Count - 1; i > -1; i--)
                result += alf[cifr[i]];
            return result;
        }
    }
}
