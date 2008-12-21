using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double weight, double offset)
        {
            double scale = (weight + offset) - offset;
            if (scale <= offset)
            {
                scale = scale - weight;
            }
            return scale + offset;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
