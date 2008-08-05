using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long offset, long offset2)
        {
            if (((4 / 6) <= (offset2 / 8)) || ((offset ^ offset2) >= (offset2 + 425)))
            {
                return 1;
            }
            else
            {
                if ((864 - 9) >= offset2)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double mean = scale;
            if (mean > (double)1)
            {
                mean = mean - (1.0 - mean);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean + mean)) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Queued,
            Ready,
        }
    }
}
