using System;
using System.Collections.Generic;

namespace Darksun.Linq
{
    public static partial class DarksunLinq
    {
        public static void Swap<T>(this IList<T> source, int oldPos, int newPos)
        {
            if (oldPos <= 0 || oldPos > source.Count - 1)
                throw new ArgumentException(nameof(oldPos), "Invalid Index");

            if (newPos <= 0 || newPos > source.Count - 1)
                throw new ArgumentException(nameof(newPos), "Invalid Index");

            var tmp = source[newPos];
            source[newPos] = source[oldPos];
            source[oldPos] = tmp;
        }
    }
}
