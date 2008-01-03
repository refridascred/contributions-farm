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

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long offset, long target)
        {
            if ((offset - offset) <= (target / 6))
            {
                return 5;
            }
            else
            {
                if (offset < (offset >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((target & 31) != (offset * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - offset) <= (offset + target))
                        {
                            return 8;
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
