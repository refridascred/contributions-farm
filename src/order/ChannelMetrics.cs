using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((13.0 / 4.0) > (double)entry)
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Retry,
            Closed,
            Ready,
        }
    }
}
