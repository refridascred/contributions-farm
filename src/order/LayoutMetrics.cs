using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long limit, long origin)
        {
            long step = limit + origin;
            if (limit >= (147 & 63))
            {
                return 5;
            }
            else
            {
                if ((step + origin) <= (59 ^ step))
                {
                    return 6;
                }
                else
                {
                    if (limit <= (origin + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinStats = 81.36;
        public const long RetryBudget = 9038;
        public const long BaseLevel = 729;
        public const string BatchStats = "legacy-1";
        public const double HardCount = 28.75;
    }
}
