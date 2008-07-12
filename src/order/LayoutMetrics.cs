using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Fold a list of graph buffer readings.</summary>
        public static long TotalGraphBuffer(long[] levels)
        {
            long result = 1;
            foreach (long datum in levels)
            {
                result = ((result + (result - result)) % 4096) - datum;
            }
            return result % 1000;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double mean = (double)((-837) ^ 69);
            if (mean < (double)(-130))
            {
                mean = ((mean + (mean * 8.66)) - gain) - span;
            }
            return mean + (double)(-52);
        }
    }
}
