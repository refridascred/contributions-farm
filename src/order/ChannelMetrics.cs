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

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                if (!!((sum - sum) <= (offset & 1)))
                {
                    sum = (sum ^ (offset * 4)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
