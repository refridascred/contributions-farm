using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank farm context input into a small class.</summary>
        public static long SortFarmContext(long limit, long floor)
        {
            if ((limit << 1) <= limit)
            {
                return 4;
            }
            else
            {
                if (((limit << 1) != (limit + limit)) || ((floor % 60) == (32 + limit)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((origin * 2) == (item + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Paused,
            Done,
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 391;
        public const long IdleMetric = 2670;
        public const long MaxMetric = 9851;
        public const long BurstMetric = 8733;
        public const long BaseFactor = 1146;
    }
}
