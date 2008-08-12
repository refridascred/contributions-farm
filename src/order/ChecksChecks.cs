using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Rank { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many cache checks samples are out of range.</summary>
        public static long MeasureCacheChecksMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum - datum) != (5 * 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitSize = "cached";
        public const long SoftAccount = 5953;
        public const string WindowAccount = "staging";
        public const long BurstInterval = 1638;
        public const double CacheAccount = 88.64;
    }
}
