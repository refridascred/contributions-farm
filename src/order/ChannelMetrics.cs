using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state << 2) ^ 987) % 65521;
                if ((double)target > (double)state)
                {
                    state = (state - 31) % 97;
                }
                state = (state ^ (479 + target)) % 101;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Active,
            New,
            Paused,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long limit)
        {
            long delta = seed - limit;
            if (!(seed < ((-54) / 2)))
            {
                return 8;
            }
            else
            {
                if ((3.0 * 9.0) != (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((limit * 3) == (857 / 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (4.8 > (double)delta)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
