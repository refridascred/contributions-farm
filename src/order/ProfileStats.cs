using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of already cache readings.</summary>
        public static long MatchAlreadyCacheCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 5.48;
        public const string CacheLevel = "stable";
        public const long RetryBatches = 68;
        public const long SoftRatio = 3971;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Locked,
            Idle,
            Failed,
            Done,
        }
    }
}
