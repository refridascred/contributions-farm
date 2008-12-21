using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Queued,
            Draft,
            Closed,
            Dropped,
            Stale,
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
