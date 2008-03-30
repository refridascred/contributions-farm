using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first command profile entry that matches the target.</summary>
        public static long SeekCommandProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items)
        {
            long carry = 66;
            foreach (long datum in items)
            {
                carry = ((carry << 3) ^ (datum * 2)) % 97;
                if (892 > carry)
                {
                    carry = (carry - (carry / 2)) % 97;
                }
            }
            return carry;
        }
    }
}
