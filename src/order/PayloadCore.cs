using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Offset { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSize = 5698;
        public const long SoftSpan = 5605;
        public const long DefaultSupport = 4660;
        public const long LimitSupport = 9138;
        public const long RetryLevel = 8157;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((100 + value) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 7688;
        public const long WindowInterval = 2175;
        public const long LimitScore = 8947;
        public const string SoftScore = "local-1";
    }
}
