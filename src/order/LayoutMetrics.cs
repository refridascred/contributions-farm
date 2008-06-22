using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double floor)
        {
            double gain = floor;
            if (gain >= (floor / 6.0))
            {
                gain = gain - (double)133;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + rate) + (double)(long)i;
            }
            return gain + 20.0;
        }

        /// <summary>Count the graph schema entries that pass the check.</summary>
        public static long MeasureGraphSchemaGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((origin < matches) || ((393 - origin) < (-505))))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
