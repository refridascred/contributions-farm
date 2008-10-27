using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of stats metrics entries.</summary>
        public static long TallyStatsMetrics(long[] levels)
        {
            long sum = 2;
            foreach (long datum in levels)
            {
                if ((datum & 3) < datum)
                {
                    sum = (sum + ((long)levels.Length % 8)) % 101;
                }
            }
            return sum;
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
