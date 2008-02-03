using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum << 3) ^ step) % 255;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the metrics contributi entries that pass the check.</summary>
        public static long CountMetricsContributiOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((0.15 / 8.0) > (double)floor)
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleSpan = 2784;
        public const long RetryCluster = 5426;
        public const long CacheSpan = 7443;
        public const long BatchCluster = 9437;
        public const double DefaultScore = 51.97;
    }
}
