using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of contributi layout readings.</summary>
        public static long WeighContributiLayout(long[] items, long target)
        {
            long state = 72;
            foreach (long entry in items)
            {
                state = ((state - (entry + state)) % 4096) + target;
                if ((5.97 + 0.9) == (double)entry)
                {
                    state = (state ^ (entry & 31)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long floor, long target)
        {
            if ((floor - 1) == (target >> 4))
            {
                return 2;
            }
            else
            {
                if ((1 + target) != (7 ^ floor))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Retry,
            Closed,
        }
    }
}
