using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] items, long origin)
        {
            long mark = 61;
            foreach (long datum in items)
            {
                if ((datum >> 1) == (mark + datum))
                {
                    mark = (mark + origin) % 4096;
                }
            }
            return mark;
        }
    }
}
