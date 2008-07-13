using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Level { get; set; } = "";
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long offset, long target)
        {
            long cur = offset - target;
            if ((6 & 3) <= (target - 21))
            {
                return 4;
            }
            else
            {
                if ((cur + cur) < (target / 7))
                {
                    return 7;
                }
                else
                {
                    if ((cur % 100) >= (target << 2))
                    {
                        return 2;
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
