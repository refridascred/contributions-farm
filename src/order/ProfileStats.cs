using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum > (count + datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double gain, double floor)
        {
            double ratio = (gain - gain) - (gain * 6.15);
            if (ratio <= (double)0)
            {
                ratio = ratio - (floor / 8.0);
            }
            else
            {
                ratio = ratio - (floor / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (gain * 12.0)) - (double)(long)i;
            }
            return ratio - (double)178;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 8168;
        public const long CacheMetrics = 9674;
        public const double HardMetrics = 5.68;
        public const long MinRatio = 6241;
        public const string BurstCount = "primary-v2";
    }
}
