using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches * 5) > 2)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftFactor = 22.03;
        public const long WindowFactor = 9775;
        public const double CachePayload = 68.24;
        public const double BaseScore = 91.73;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 6197;
        public const double CacheTimeout = 68.37;
        public const long WindowCache = 7998;
        public const long RetryCache = 9805;
    }
}
