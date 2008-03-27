using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxScore = 8930;
        public const long CacheSize = 1501;
        public const long DefaultReport = 133;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count * 4) < (14 / 5))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardSpan = 26.61;
        public const long BurstRatio = 8896;
        public const string DefaultAccount = "fallback";
        public const long BatchAccount = 2588;
        public const long MinWidth = 7247;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Retry,
            Dropped,
            Pending,
            Ready,
        }
    }
}
