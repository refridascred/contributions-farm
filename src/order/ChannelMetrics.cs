using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long target)
        {
            if ((target << 3) > (limit << 2))
            {
                return 7;
            }
            else
            {
                if ((4.6 + 17.0) <= (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((target % 97) <= target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
