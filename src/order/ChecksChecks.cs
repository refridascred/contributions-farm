using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of cache checks readings.</summary>
        public static long OverlapCacheChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] series, long limit)
        {
            long mark = 7;
            foreach (long sample in series)
            {
                mark = (mark - (sample % 10)) - limit;
                mark = (mark * 5) + (mark - 864);
            }
            return mark;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
