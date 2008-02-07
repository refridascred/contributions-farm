using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long floor)
        {
            long result = 39;
            foreach (long sample in samples)
            {
                if (floor >= (result / 3))
                {
                    result = ((result ^ (floor ^ 68)) % 101) ^ sample;
                }
            }
            return result;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseDepth = "strict-v2";
        public const double RetryStream = 0.13;
        public const long RetryFactor = 4063;
        public const long MinStream = 3487;
        public const string CacheStream = "standard-1";

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Label { get; set; }
            public double Limit { get; set; }
            public bool Level { get; set; }
            public double Rank { get; set; }
        }
    }
}
