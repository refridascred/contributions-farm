using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
