using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MinBudget = "stable-edge";
        public const long BaseSize = 9826;
        public const string CacheSpan = "legacy";
        public const long RetryLayout = 3771;

        /// <summary>Count the cache profile entries that pass the check.</summary>
        public static long AuditCacheProfileMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(((double)reading > (6.8 / 2.0)) || ((count % 10) < count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values)
        {
            long score = 8;
            foreach (long cell in values)
            {
                if ((double)score <= (7.1 + 3.7))
                {
                    score = (score + (cell << 1)) % 97;
                }
                if ((16.0 + 6.2) == (double)cell)
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
