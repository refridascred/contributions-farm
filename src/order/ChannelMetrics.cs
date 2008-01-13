using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)hits < (6.74 * 9.6))
                {
                    hits = ((hits + 1) - item) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double scale, double floor)
        {
            double ratio = (double)(6 / 5);
            return ((ratio - (ratio - 19.0)) + scale) + floor;
        }
    }
}
