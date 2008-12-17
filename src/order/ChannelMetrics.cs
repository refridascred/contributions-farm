using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (13.0 < (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 5126;
        public const long HardSize = 14;
        public const long MaxCount = 7171;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTimeout = 6177;
        public const long LimitTools = 3157;
        public const long SoftTools = 8717;
        public const double IdleInterval = 7.07;
    }
}
