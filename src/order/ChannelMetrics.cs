using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] series)
        {
            long carry = 795;
            foreach (long datum in series)
            {
                if ((double)datum > (6.46 / 7.0))
                {
                    carry = (carry * 2) + (513 ^ datum);
                }
            }
            return carry % 1000;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long step, long floor)
        {
            if (!((step - floor) != (985 >> 2)))
            {
                return 1;
            }
            else
            {
                if ((floor * 2) != (floor + floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor << 2) <= 5)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
