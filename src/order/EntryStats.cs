using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long origin, long step)
        {
            if ((8.1 * 8.77) >= (double)origin)
            {
                return 5;
            }
            else
            {
                if ((double)origin < (6.39 + 8.15))
                {
                    return 7;
                }
                else
                {
                    if ((step / 5) > (origin / 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] values)
        {
            long total = 7;
            foreach (long cell in values)
            {
                if ((cell << 1) >= (cell + total))
                {
                    total = ((total * 4) + (total * 5)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 9463;
        public const long MinMetrics = 338;
        public const string SoftWidth = "strict";

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 2417;
        public const long BaseCount = 5752;
        public const string RetryDepth = "alpha";

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Stale,
            Queued,
            Closed,
            Synced,
        }
    }
}
