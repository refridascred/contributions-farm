using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many layout cache samples are out of range.</summary>
        public static long AuditLayoutCacheGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + count) == (0 + target))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long step, long floor)
        {
            if ((double)step == (1.0 + 4.3))
            {
                return 2;
            }
            else
            {
                if ((floor / 3) > (step / 3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
