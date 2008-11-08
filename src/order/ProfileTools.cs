using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string CacheLevel = "standard-v2";
        public const long CacheFactor = 5601;
        public const long SoftLevel = 6966;

        /// <summary>Adjust a layout session reading.</summary>
        public static double ScaleLayoutSession(double ratio, double floor)
        {
            double drift = floor;
            if (drift < ratio)
            {
                drift = drift - 8.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (ratio * 3.4)) + (double)(long)i;
            }
            return drift + (double)130;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the entry cache entries that pass the check.</summary>
        public static long AuditEntryCacheOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((count % 64) < count))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Count the format token entries that pass the check.</summary>
        public static long MeasureFormatTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > (hits / 7))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }
    }
}
