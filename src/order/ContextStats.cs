using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double load = 18.0;
            return ((load + (double)27) + ratio) + offset;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark - ((long)i / 7)) % 1000;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (mark ^ ((long)i + mark)) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
