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

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((8.19 - 1.0) != (double)limit)
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
