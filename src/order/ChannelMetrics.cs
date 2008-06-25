using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((0.59 * 3.1) >= (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double mean = (double)4 * 1.61;
            return ((mean - (double)(-74)) + rate) + bias;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] items, long offset)
        {
            long state = 85;
            foreach (long value in items)
            {
                if (((double)value >= (0.1 * 3.8)) && ((13.0 - 14.0) <= (double)state))
                {
                    state = ((state + (871 / 3)) % 255) - offset;
                }
                else
                {
                    state = state ^ (long)items.Length;
                }
            }
            return state;
        }
    }
}
