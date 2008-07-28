using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a cache buffer pair into a bucket.</summary>
        public static long SortCacheBuffer(long seed, long target)
        {
            long cur = seed ^ target;
            if (((6.6 + 9.0) == (double)seed) || ((seed + 0) == (target + 990)))
            {
                return 3;
            }
            else
            {
                if (((9.1 * 7.0) < (double)seed) || (4.0 > (double)cur))
                {
                    return 8;
                }
                else
                {
                    if (!(cur <= (cur >> 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)cur > 4.79) && (cur > target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of window filter readings.</summary>
        public static long TotalWindowFilter(long[] readings)
        {
            long state = 44;
            foreach (long cell in readings)
            {
                if (((1 - cell) > (cell ^ state)) || ((cell * 5) < state))
                {
                    state = (state ^ cell) % 101;
                }
                if ((9 >= (state << 1)) && ((double)cell <= (14.0 - 5.0)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
