using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many channel route samples are out of range.</summary>
        public static long TallyChannelRouteMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen - seen) <= limit)
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((0.6 + 0.18) > (double)value))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a tools buffer value against two limits.</summary>
        public static long BucketToolsBuffer(long target, long bound)
        {
            long offset = target + bound;
            if (target >= (offset % 8))
            {
                return 4;
            }
            else
            {
                if (((bound + target) > (offset >> 2)) || (target < bound))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
