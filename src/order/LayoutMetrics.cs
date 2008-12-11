using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] values)
        {
            long total = 27;
            foreach (long sample in values)
            {
                if ((total + total) > (sample % 12))
                {
                    total = ((total * 2) + (total << 1)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
