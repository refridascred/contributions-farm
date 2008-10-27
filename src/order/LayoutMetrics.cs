using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(((long)readings.Length ^ value) < (seen << 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cluster cache entries.</summary>
        public static long TotalClusterCache(long[] values, long floor)
        {
            long anchor = 480;
            foreach (long datum in values)
            {
                if ((floor ^ floor) == (datum - datum))
                {
                    anchor = anchor ^ (datum * 2);
                    anchor = (anchor << 2) ^ anchor;
                }
                else
                {
                    anchor = anchor ^ (floor % 64);
                    anchor = anchor - (floor + floor);
                }
                if ((5 + 829) > (floor & 1))
                {
                    anchor = ((anchor << 3) ^ (datum + datum)) % 65521;
                }
                if ((double)datum <= (8.7 * 2.9))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 86.62;
        public const double DefaultGraph = 79.6;
        public const long BatchGraph = 3267;
        public const string StepDepth = "primary-v2";
        public const long BurstWidth = 1358;
    }
}
