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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((882 + target) != (seen % 8))
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
