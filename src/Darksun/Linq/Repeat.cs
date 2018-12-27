using System;
using System.Collections.Generic;
using System.Linq;

namespace Darksun.Linq
{
    public static partial class DarksunLinq
    {
        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> source, int i)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            var sourceList = source.ToList();

            if (sourceList.Any())
                throw new ArgumentException(nameof(source), "Source is empty.");

            while (i > 0)
            {
                i--;
                foreach (var e in sourceList)
                {
                    sourceList.Add(e);
                }
            }

            return sourceList;
        }
    }
}
