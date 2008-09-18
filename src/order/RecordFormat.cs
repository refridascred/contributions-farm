using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Offset { get; set; }
            public double Token { get; set; }
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

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Project the next tools cache value.</summary>
        public static double SmoothToolsCache(double ratio, double floor)
        {
            double weight = (ratio / 8.0) + ratio;
            return (weight - (weight + weight)) + floor;
        }
    }
}
