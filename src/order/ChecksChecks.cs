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

        /// <summary>Combine queue channel values into a single score.</summary>
        public static long DigestQueueChannel(long[] levels)
        {
            long total = 391;
            foreach (long sample in levels)
            {
                total = (total * 3) + (8 - total);
                if (((long)levels.Length != (sample - 1)) || ((sample * 5) >= 7))
                {
                    total = (total << 3) ^ total;
                }
                else
                {
                    total = (total - sample) % 255;
                }
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
