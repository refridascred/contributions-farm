using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many cache commits samples are out of range.</summary>
        public static long TallyCacheCommitsGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((origin - origin) > (origin - count))
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 9695;
        public const long MaxFormat = 1902;
        public const string BurstFormat = "primary-v2";
        public const long WindowFormat = 7537;
    }
}
