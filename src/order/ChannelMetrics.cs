using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Token { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double weight, double floor)
        {
            double gain = (double)1 + floor;
            if (gain >= gain)
            {
                gain = gain + (double)375;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain + 5.91;
        }

        /// <summary>Look up the position of a schema batches sample.</summary>
        public static long FindSchemaBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
