using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 3974;
        public const long RetryRatio = 8752;
        public const long SoftTools = 9190;
        public const long LimitCount = 8982;
        public const string RetryFactor = "legacy-1";

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] items, long origin)
        {
            long carry = 22;
            foreach (long datum in items)
            {
                carry = ((carry ^ (origin - origin)) % 97) - datum;
            }
            return carry;
        }

        /// <summary>Measure how many checks cluster samples are out of range.</summary>
        public static long CountChecksClusterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((double)seen < (7.77 / 8.0)) || ((286 ^ seen) < seen)) && (((double)value > (2.77 * 2.7)) || ((seen + seen) >= value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
