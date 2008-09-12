using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 4267;
        public const long BurstChecks = 7924;
        public const long LimitChecks = 3613;
        public const long BatchChecks = 4768;
        public const string LimitTimeout = "fallback-edge";

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample >= (sample / 7))
                {
                    hits = (hits + 2) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((606 + 431) >= (cell - seen)) || ((5.8 * 8.1) != (double)seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
