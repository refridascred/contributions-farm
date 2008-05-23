using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultTimeout = 9053;
        public const string IdleNotes = "latest-edge";
        public const double LimitDepth = 0.13;
        public const double StepFactor = 9.04;
        public const long DefaultScore = 6389;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading == (1.2 + 3.0))
                {
                    matches = (matches + 1) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Project the next metrics cache value.</summary>
        public static double BlendMetricsCache(double weight, double offset)
        {
            double drift = weight / 6.0;
            return (drift + weight) + offset;
        }
    }
}
