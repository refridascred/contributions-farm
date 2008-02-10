using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string CacheAlready = "open";
        public const long DefaultAlready = 8611;
        public const long CacheCount = 5504;
        public const double MinTimeout = 85.84;
        public const long RetryTimeout = 3819;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally < (tally << 2))
                {
                    tally = ((tally + 1) - cell) - bound;
                }
            }
            return tally;
        }
    }
}
