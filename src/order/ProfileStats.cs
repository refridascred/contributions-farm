using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 8368;
        public const double StepRatio = 33.79;
        public const double CacheRatio = 84.66;
        public const double MinWidth = 85.04;

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double scale, double span)
        {
            double ratio = (span * 7.94) - span;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio + 13.0;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count / 2) <= (sample % 100))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultDepth = 6.96;
        public const long RetryMetric = 2202;
        public const double WindowWidth = 24.68;
        public const long HardSpan = 6218;
    }
}
