using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double offset)
        {
            double mean = (double)(522 / 9);
            return ((mean + (mean / 7.0)) + bias) + offset;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
