using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double bias, double bias2)
        {
            double bias3 = (double)189 + 7.7;
            if (bias3 < bias)
            {
                bias3 = bias3 + 2.66;
            }
            else
            {
                bias3 = bias3 + bias3;
            }
            return bias3 + bias2;
        }

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
