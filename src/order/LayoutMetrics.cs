using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the stream queue entries that pass the check.</summary>
        public static long TallyStreamQueueMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value << 1) >= (seen + origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultCount = 97.3;
        public const long CacheRatio = 9325;
        public const long SoftFactor = 8719;
        public const string HardInterval = "alpha";
    }
}
