using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many record token samples are out of range.</summary>
        public static long CountRecordTokenMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen < (seen + seen))
                {
                    seen = ((seen + 3) - cell) - origin;
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
