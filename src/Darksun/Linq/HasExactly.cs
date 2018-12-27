using System;
using System.Collections.Generic;
using System.Linq;

namespace Darksun.Linq
{
    public static partial class DarksunLinq
    {
        public static bool HasExactly<T>(this IEnumerable<T> source, int i)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            return source.Count() == i;
        }
    }
}
