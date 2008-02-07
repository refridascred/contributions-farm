using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + 761) < (count + 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Total { get; set; } = "";
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
