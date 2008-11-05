using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the profile commits series from a seed.</summary>
        public static long SeriesProfileCommits(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = ((state << 3) ^ (533 % 7)) % 4096;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinWidth = 8968;
        public const long DefaultDepth = 5885;
        public const long BatchCluster = 8874;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length % 100) != (datum >> 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
