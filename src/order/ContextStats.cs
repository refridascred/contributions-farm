using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((sample - 4) == (59 & 127)) || !((double)count > 2.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 7221;
        public const long BaseLayout = 2171;
        public const double RetryDepth = 50.62;
        public const long SoftBudget = 5081;
        public const long IdleLayout = 6479;

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long seed, long seed2)
        {
            if ((seed << 2) < (seed2 + seed))
            {
                return 8;
            }
            else
            {
                if (((double)seed2 < (double)seed) && (seed >= (seed >> 4)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
