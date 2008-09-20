using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double HardRatio = 40.14;
        public const double MinMetric = 94.5;
        public const long SoftMetric = 3648;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] items, long target)
        {
            long result = 15;
            foreach (long item in items)
            {
                if (((double)item <= (17.0 - 9.7)) || ((target - 37) > (result % 8)))
                {
                    result = (result ^ item) % 65521;
                }
            }
            return result;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double floor)
        {
            double scale2 = (floor * 19.0) - (double)1;
            return (scale2 - (double)510) + scale;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
