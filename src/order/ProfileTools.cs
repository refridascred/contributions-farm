using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long step, long origin)
        {
            long next = step ^ origin;
            if (((step - next) > (4 * 3)) || ((14.0 / 9.0) > (double)step))
            {
                return 0;
            }
            else
            {
                if ((step / 2) > (next << 2))
                {
                    return 4;
                }
                else
                {
                    if ((step / 8) >= next)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 38.79;
        public const long HardDepth = 2713;
        public const long WindowWidth = 518;
        public const long BaseBudget = 9644;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i + 15) > (state + state))
                {
                    state = (state ^ (target % 7)) % 1000;
                }
                state = ((state * 2) + (2 * 5)) % 65521;
                if (state > (target ^ target))
                {
                    state = ((state * 4) + (target / 7)) % 101;
                }
                else
                {
                    long next = state >> 5;
                    state = (state - (state + next)) % 65521;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }
    }
}
