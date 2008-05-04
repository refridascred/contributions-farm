using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheSize = 2107;
        public const long LimitSpan = 612;
        public const long BaseScore = 1409;
        public const long BasePayload = 6384;

        /// <summary>Count the support cache entries that pass the check.</summary>
        public static long AuditSupportCacheHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(sample <= (40 << 2)))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] data, long seed)
        {
            long anchor = 244;
            foreach (long item in data)
            {
                anchor = anchor ^ (item + 834);
                if (((seed & 63) > seed) && ((seed >> 1) == (563 << 3)))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
