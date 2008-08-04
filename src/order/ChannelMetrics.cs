using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long seed)
        {
            long step = offset + seed;
            if ((step + step) <= (6 + (-8)))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (3.5 / 3.0))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinQueue = "standard";
        public const string StepQueue = "open-1";
        public const long RetryQueue = 5700;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }
    }
}
