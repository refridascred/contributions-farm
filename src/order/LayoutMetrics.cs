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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = (total - origin) % 255;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
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
