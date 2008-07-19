using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every tools layout entry stays within the limit.</summary>
        public static bool ValidateToolsLayoutBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first metrics batch entry that matches the target.</summary>
        public static long SeekMetricsBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark * 5) + mark;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series, long origin)
        {
            long total = 93;
            foreach (long datum in series)
            {
                if (!((4 + total) > origin))
                {
                    total = total + origin;
                }
                total = total ^ (total + datum);
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 8626;
        public const long DefaultInterval = 9824;
        public const long BaseMetrics = 8847;
        public const long LimitMetrics = 9410;
        public const long CacheRatio = 8569;
    }
}
