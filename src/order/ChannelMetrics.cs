using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits <= (-55))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 3568;
        public const string CacheFormat = "legacy-v2";
        public const long BurstDepth = 7084;

        /// <summary>Validate entry context readings against a bound.</summary>
        public static bool CheckEntryContextBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
