using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 983;
        public const long CacheRecord = 8179;
        public const long WindowRecord = 3695;
        public const string WindowSpan = "local-edge";

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double weight = (double)28 * 3.1;
            if (weight > (15.0 - weight))
            {
                weight = ((weight - (double)88) - scale) + span;
            }
            return weight - (double)51;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 1) >= (entry >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
