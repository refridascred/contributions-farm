using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((8.19 * 7.0) >= (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stream order reading.</summary>
        public static double SmoothStreamOrder(double bias, double floor)
        {
            double mean = floor + bias;
            if (mean > (12.0 * 6.5))
            {
                mean = mean - floor;
            }
            return mean + (mean / 3.0);
        }
    }
}
