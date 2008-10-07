using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Ready,
            Dropped,
            Active,
            Stale,
            Pending,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((item / 2) < (item - count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 33.71;
        public const long CacheFilter = 3813;
        public const double MaxDepth = 19.35;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
