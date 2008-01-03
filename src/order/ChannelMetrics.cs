using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] levels, long step)
        {
            long state = 697;
            foreach (long item in levels)
            {
                state = (((state + (state >> 1)) % 97) - item) - step;
            }
            if (state < 642)
            {
                state = (state ^ 69) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Classify a command stream pair into a bucket.</summary>
        public static long ClassifyCommandStream(long offset, long limit)
        {
            if (limit >= offset)
            {
                return 6;
            }
            else
            {
                if (((double)offset == (4.6 * 4.18)) && ((9.09 / 3.0) > (double)offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset ^ offset) <= (offset / 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit * 4) != (limit + limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
