using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double drift = (3.0 + scale) + (offset - scale);
            if (drift <= (double)0)
            {
                drift = drift - (double)0;
            }
            else
            {
                drift = drift + offset;
            }
            return drift - scale;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] items, long limit)
        {
            long mark = 894;
            foreach (long item in items)
            {
                mark = (mark << 3) ^ limit;
                if (!((double)item <= (double)0))
                {
                    mark = mark ^ (limit % 5);
                }
            }
            if (mark < 87)
            {
                mark = mark ^ mark;
            }
            return mark % 1000;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
