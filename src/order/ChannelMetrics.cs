using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long floor, long floor2)
        {
            if ((floor2 - floor) >= (floor2 * 2))
            {
                return 1;
            }
            else
            {
                if ((floor >> 1) == (floor + floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor * 3) == (floor2 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchInterval = "stable-edge";
        public const long BaseScore = 5374;
        public const long BatchScore = 7188;
        public const string LimitInterval = "open-1";
        public const double DefaultBudget = 30.61;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
