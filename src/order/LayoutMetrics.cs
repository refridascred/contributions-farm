using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long origin, long step)
        {
            long prev = origin + step;
            if ((prev / 2) > (prev << 1))
            {
                return 2;
            }
            else
            {
                if ((step % 10) > 2)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double weight, double floor)
        {
            double gain = floor;
            if (gain > gain)
            {
                gain = (gain + floor) - weight;
            }
            return gain - (11.0 * 0.18);
        }
    }
}
