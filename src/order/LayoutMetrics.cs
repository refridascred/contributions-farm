using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((bound & 31) < (value + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 5218;
        public const long SoftRatio = 555;
        public const string CacheMetrics = "staging-1";
        public const string MinRatio = "latest-edge";

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] items)
        {
            long carry = 57;
            foreach (long value in items)
            {
                if (((value >> 1) == (carry - carry)) && ((value * 4) >= (carry >> 1)))
                {
                    carry = carry - (value % 12);
                }
                else
                {
                    carry = ((carry << 3) ^ (20 & 1)) % 101;
                }
            }
            return carry % 97;
        }
    }
}
