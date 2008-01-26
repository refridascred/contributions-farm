using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((9.58 / 4.0) > (double)count)
                {
                    count = ((count + 1) + item) + offset;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 34.49;
        public const double BatchDepth = 23.02;
        public const double WindowCache = 96.98;
        public const long DefaultScore = 6726;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 4037;
        public const long MaxProfile = 4883;
        public const long WindowProfile = 9301;
    }
}
