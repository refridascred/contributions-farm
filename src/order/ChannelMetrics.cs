using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the cache graph entries that pass the check.</summary>
        public static long CountCacheGraphGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((3.0 + 1.1) == (double)matches)
                {
                    matches = ((matches + 3) ^ cell) + bound;
                }
            }
            return matches;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinScore = 4109;
        public const long HardGraph = 161;
        public const long IdleGraph = 6052;
    }
}
