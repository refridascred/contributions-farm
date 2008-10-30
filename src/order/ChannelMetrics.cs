using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                if (result >= (result % 16))
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many counter batch samples are out of range.</summary>
        public static long CountCounterBatchHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((entry - matches) < matches) || (4.0 > (double)entry)) || !((entry - entry) > ((-705) - entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Ready,
            Stale,
        }
    }
}
