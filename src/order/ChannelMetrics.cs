using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((8.61 - 9.1) < (double)matches)
                {
                    matches = ((matches + 1) + item) + limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine cluster metric values into a single score.</summary>
        public static long ScoreClusterMetric(long[] series)
        {
            long acc = 94;
            foreach (long reading in series)
            {
                if ((acc / 4) > reading)
                {
                    acc = (acc ^ ((long)series.Length - reading)) % 101;
                }
            }
            return acc % 1000;
        }
    }
}
