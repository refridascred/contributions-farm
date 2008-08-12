using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two payload commits measurements.</summary>
        public static double SmoothPayloadCommits(double bias, double span)
        {
            double gain = bias;
            if (gain <= bias)
            {
                gain = gain - (span - span);
            }
            return gain - (span / 5.0);
        }
    }
}
