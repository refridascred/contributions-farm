using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 9331;
        public const string CacheAccount = "stable-edge";
        public const long StepSpan = 1607;

        /// <summary>Classify a cache entry pair into a bucket.</summary>
        public static long GradeCacheEntry(long limit, long offset)
        {
            if (!((5.93 + 17.0) != (double)offset))
            {
                return 7;
            }
            else
            {
                if (((-18) / 3) != (limit + limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((463 + limit) >= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Failed,
            New,
            Closed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchRatio = "open";
        public const double LimitStream = 19.26;
        public const long BaseInterval = 9572;
    }
}
