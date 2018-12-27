using System;
using System.Collections.Generic;
using System.Linq;

namespace Darksun.Linq
{
    public static partial class DarksunLinq
    {
        public static IEnumerable<T> RandomSelect<T>(
            this IEnumerable<T> source, int elementCount)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (elementCount <= 0)
                throw new ArgumentException(nameof(elementCount), "ElementCount can not be 0 or negative");

            var sourceArray = source.ToArray();

            if (!sourceArray.Any())
                throw new ArgumentException(nameof(source), "Source can not be empty");


            return PickRandom(sourceArray, new Random());
        }

        private static IEnumerable<T> PickRandom<T>(IEnumerable<T> source, Random random)
        {
            var elements = source.ToArray();

            for (var n = 0; n < elements.Length; n++)
            {
                var k = random.Next(n, elements.Length);
                yield return elements[k];

                elements[k] = elements[n];
            }
        }
    }
}
