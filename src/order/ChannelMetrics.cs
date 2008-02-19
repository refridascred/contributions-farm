using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long floor)
        {
            long slot = seed - floor;
            if ((seed >> 4) < (floor / 4))
            {
                return 8;
            }
            else
            {
                if (((slot ^ seed) < (seed - floor)) || ((9.07 * 6.8) <= (double)seed))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first stream cache entry that matches the target.</summary>
        public static long FindStreamCacheIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double rate, double floor)
        {
            double gain = (double)(2 % 12);
            if (gain > (gain * 7.8))
            {
                gain = (gain + (double)172) + floor;
            }
            else
            {
                gain = gain + (2.0 / 5.0);
            }
            return gain + rate;
        }
    }
}
