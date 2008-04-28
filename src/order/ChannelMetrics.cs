using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8038;
        public const long RetryBatches = 3292;
        public const long LimitSize = 4582;
        public const long MaxFactor = 8615;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
