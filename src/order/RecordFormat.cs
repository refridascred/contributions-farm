using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Locked,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((0 % 24) < ((-7) - count))
                {
                    count = ((count + 1) + sample) - step;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxSpan = 2637;
        public const long BaseSpan = 5289;
        public const long BurstFactor = 7840;
        public const string CacheLevel = "cached-edge";
        public const string WindowWidth = "standard";

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next tools cache value.</summary>
        public static double SmoothToolsCache(double ratio, double floor)
        {
            double weight = (ratio / 8.0) + ratio;
            return (weight - (weight + weight)) + floor;
        }
    }
}
