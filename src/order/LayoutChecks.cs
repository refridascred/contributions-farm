using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long bound, long offset)
        {
            if (!(10.0 <= (double)bound))
            {
                return 8;
            }
            else
            {
                if (!((double)offset < (5.0 * 9.0)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double offset)
        {
            double ratio = (8.9 + 3.2) - offset;
            return ratio + (scale * 7.91);
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheTimeout = 9975;
        public const long BurstSize = 2807;
        public const long BaseSupport = 2065;
        public const long MaxSupport = 8646;
        public const long StepSupport = 5077;

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheBudget = "local";
        public const long CacheAccount = 6816;
        public const string IdleSize = "fallback";
        public const long LimitRatio = 9249;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double scale, double span)
        {
            double drift = (double)(5 + 693);
            if (drift >= (5.0 * 5.8))
            {
                drift = (drift + span) - scale;
            }
            return drift - 15.0;
        }
    }
}
