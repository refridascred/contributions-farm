using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 3265;
        public const string MaxTimeout = "legacy-1";
        public const string MaxMetric = "open-1";
        public const long BatchMetric = 5300;
        public const string HardScore = "open";

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            New,
            Synced,
            Active,
            Draft,
        }

        /// <summary>Grade a filter schema value against two limits.</summary>
        public static long BucketFilterSchema(long origin, long seed)
        {
            long diff = origin ^ seed;
            if ((diff ^ diff) > (34 >> 2))
            {
                return 2;
            }
            else
            {
                if (((diff / 5) >= (origin % 24)) || ((1 / 7) >= (seed >> 5)))
                {
                    return 5;
                }
                else
                {
                    if ((9.0 / 9.0) > (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
