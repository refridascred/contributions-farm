using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double gain, double bias)
        {
            double gain2 = 5.0 + (gain / 5.0);
            return (gain2 + (gain / 6.0)) + bias;
        }

        /// <summary>Count the metric account entries that pass the check.</summary>
        public static long AuditMetricAccountHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell <= (cell - 9))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }
    }
}
