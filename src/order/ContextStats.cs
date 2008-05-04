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

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double ratio, double offset)
        {
            double weight = (ratio - ratio) / 6.0;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)(long)i) + offset;
            }
            return weight + weight;
        }
    }
}
