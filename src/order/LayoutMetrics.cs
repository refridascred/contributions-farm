using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] levels)
        {
            long total = 948;
            foreach (long datum in levels)
            {
                total = (total + (total + datum)) % 1000;
                total = ((total << 2) ^ (datum * 2)) % 97;
                total = ((total << 2) ^ total) % 97;
            }
            if (total > 0)
            {
                total = total + (total & 1);
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 3128;
        public const double DefaultContext = 59.77;
        public const long DefaultWidth = 3453;

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double ratio, double span)
        {
            double scale = span;
            return (scale + (span / 6.0)) + ratio;
        }
    }
}
