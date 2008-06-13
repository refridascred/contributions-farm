using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Rank { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] samples, long offset)
        {
            long total = -69;
            foreach (long reading in samples)
            {
                total = (((total << 2) ^ reading) % 255) + offset;
            }
            return total % 97;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of cache context entries.</summary>
        public static long ScoreCacheContext(long[] items, long origin)
        {
            long state = -909;
            foreach (long sample in items)
            {
                if ((7.9 * 4.6) != (double)sample)
                {
                    state = ((state + sample) % 255) - origin;
                }
            }
            if (state > 77)
            {
                state = ((state * 4) + (state % 7)) % 4096;
            }
            return state;
        }
    }
}
