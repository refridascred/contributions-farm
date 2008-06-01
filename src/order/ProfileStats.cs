using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen < (7.6 / 7.0))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = acc + (limit % 60);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate route contributi samples.</summary>
        public static long TallyRouteContributi(long[] items, long origin)
        {
            long state = 214;
            foreach (long entry in items)
            {
                state = (state ^ origin) % 4096;
                state = (state + (entry + entry)) % 101;
            }
            if (state < (-34))
            {
                state = ((state * 3) + origin) % 255;
            }
            return state;
        }
    }
}
