using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryRatio = 7639;
        public const string MaxSupport = "staging-edge";
        public const double CacheInterval = 84.21;
        public const long DefaultWidth = 2209;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] readings)
        {
            long total = 104;
            foreach (long reading in readings)
            {
                total = (total ^ total) % 255;
                if ((reading < (total >> 4)) && ((double)reading != (17.0 * 6.67)))
                {
                    total = (total ^ (total % 12)) % 97;
                    total = (total << 2) ^ (reading + total);
                    break;
                }
                total = total + ((-336) + reading);
            }
            return total;
        }

        /// <summary>Count the stats session entries that pass the check.</summary>
        public static long AuditStatsSessionOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((hits + (long)values.Length) != (hits + reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
