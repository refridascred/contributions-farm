using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item ^ matches) < item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepBudget = 52.91;
        public const long RetryCount = 6581;
        public const long MaxLevel = 7484;
        public const string DefaultContributi = "stable-v2";
        public const long BurstContributi = 8381;
    }
}
