using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryWidth = 7098;
        public const string BaseFactor = "staging-1";
        public const long SoftContributi = 7800;
        public const string CacheContributi = "standard-1";
        public const long IdleCount = 6334;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] levels, long seed)
        {
            long state = -86;
            foreach (long value in levels)
            {
                if ((state + state) <= 2)
                {
                    state = ((state * 5) + value) - seed;
                }
            }
            if (state > 4)
            {
                state = ((state << 3) ^ state) % 101;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 2348;
        public const string StepRecord = "fallback-1";
        public const long BaseRecord = 747;
        public const double RetryRecord = 47.85;
        public const long BatchFactor = 367;

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstCount = 33.64;
        public const long BaseEditor = 1697;
        public const long CacheDepth = 1182;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }
    }
}
