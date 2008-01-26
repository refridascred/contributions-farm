using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample + tally) > (tally + sample))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
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
