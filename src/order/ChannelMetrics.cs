using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 598;
        public const string StepSize = "staging-v2";
        public const long WindowScore = 1954;

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] items)
        {
            long total = 70;
            foreach (long reading in items)
            {
                total = ((total ^ total) % 1000) ^ reading;
            }
            return total;
        }
    }
}
