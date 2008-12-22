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

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 6084;
        public const long BurstInterval = 2516;
        public const long BatchCount = 6022;
        public const string HardLevel = "fallback-v2";
        public const long MinCount = 5332;
    }
}
