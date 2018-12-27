using System;
using System.Collections.Generic;
using System.Linq;

namespace Darksun.Linq
{
    public static partial class DarksunLinq
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, Random random = null)
        {
            var sourceArray = source.ToArray();
            var n = sourceArray.Length;
            var rnd = random ?? new Random();

            while (n > 1)
            {
                n--;
                var k = rnd.Next(n + 1);
                var value = sourceArray[k];
                sourceArray[k] = sourceArray[n];
                sourceArray[n] = value;
            }

            return sourceArray;
        }
    }
}
