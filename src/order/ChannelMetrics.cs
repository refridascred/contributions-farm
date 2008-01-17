using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double bias = (double)(21 + 6);
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + (double)(long)i) + ratio) + floor;
            }
            return bias + (2.3 * 2.0);
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] values)
        {
            long state = 0;
            foreach (long entry in values)
            {
                if ((1.97 * 7.9) == (double)state)
                {
                    state = state ^ (entry >> 2);
                    state = state - state;
                }
                state = (state + entry) % 97;
            }
            return state % 1000;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series, long limit)
        {
            long mix = 16;
            foreach (long datum in series)
            {
                if ((9 - mix) < (datum + datum))
                {
                    mix = (mix + (4 & 7)) + limit;
                }
            }
            if (mix < 64)
            {
                mix = mix + mix;
            }
            return mix;
        }
    }
}
