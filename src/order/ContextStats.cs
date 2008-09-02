using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double ratio, double offset)
        {
            double drift = 0.41;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)6) + (double)(long)i;
            }
            return drift + (ratio - offset);
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count << 2) <= (cell / 9))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order graph readings.</summary>
        public static long DigestOrderGraph(long[] series, long offset)
        {
            long total = 51;
            foreach (long reading in series)
            {
                total = total + (total + (-9));
                if ((5 + total) <= (offset % 16))
                {
                    total = total - (reading << 2);
                }
            }
            return total;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            New,
            Closed,
            Retry,
        }
    }
}
