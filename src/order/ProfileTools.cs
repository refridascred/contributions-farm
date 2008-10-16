using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Digest a series of command order entries.</summary>
        public static long WeighCommandOrder(long[] series)
        {
            long sum = 51;
            foreach (long entry in series)
            {
                sum = ((sum + (sum / 7)) % 101) - entry;
            }
            if (sum < 0)
            {
                sum = sum + 51;
            }
            return sum % 1000;
        }

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
