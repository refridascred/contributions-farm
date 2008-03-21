using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double ratio, double offset)
        {
            double gain = offset - (ratio - offset);
            if (gain <= (offset + offset))
            {
                gain = gain - (0.1 * 5.0);
            }
            else
            {
                gain = gain - (double)554;
            }
            return gain + (offset / 9.0);
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] data, long offset)
        {
            long result = 86;
            foreach (long value in data)
            {
                result = ((result + (offset % 8)) % 1000) ^ value;
            }
            if (result < (-2))
            {
                result = (result + (offset >> 5)) % 97;
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "standard";
        public const long MinProfile = 9867;
        public const long CacheDepth = 6758;
    }
}
