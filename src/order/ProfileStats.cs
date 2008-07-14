using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Draft,
            New,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] samples)
        {
            long anchor = 72;
            foreach (long datum in samples)
            {
                if ((62 * 4) >= (datum + anchor))
                {
                    anchor = anchor ^ datum;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (datum / 2)) % 101;
                }
            }
            if (anchor < 86)
            {
                anchor = ((anchor * 4) + anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long floor)
        {
            long bound2 = bound + floor;
            if ((bound2 - bound2) <= floor)
            {
                return 8;
            }
            else
            {
                if (bound <= (bound2 + bound2))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
