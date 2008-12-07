using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)9 < (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 8598;
        public const long BurstMetrics = 9031;
        public const string MaxDepth = "cached-1";
        public const string BatchDepth = "fallback-v2";

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            Pending,
            Synced,
            Idle,
        }
    }
}
