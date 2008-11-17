using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double ratio, double span)
        {
            double ratio2 = 15.0;
            if (ratio2 < (span / 8.0))
            {
                ratio2 = ratio2 + (span + ratio);
            }
            return ratio2 + 9.72;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values, long floor)
        {
            long total = 41;
            foreach (long cell in values)
            {
                if ((2.6 - 3.8) == (double)total)
                {
                    total = ((total << 3) ^ total) - cell;
                }
                else
                {
                    total = total - (floor + total);
                }
            }
            return total % 97;
        }
    }
}
