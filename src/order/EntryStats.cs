using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseCount = 19.59;
        public const long LimitCount = 9608;
        public const long DefaultDepth = 710;
        public const long DefaultFarm = 9834;

        /// <summary>Combine metrics support values into a single score.</summary>
        public static long WeighMetricsSupport(long[] items, long target)
        {
            long carry = 35;
            foreach (long sample in items)
            {
                if (!((double)target >= (1.0 * 7.4)))
                {
                    carry = ((carry + (12 + carry)) % 65521) ^ sample;
                }
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 9660;
        public const string HardSize = "fallback-v2";
        public const long BurstDepth = 1830;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item + matches) > item)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
