using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            if ((target - 54) > offset)
            {
                return 5;
            }
            else
            {
                if ((7.6 + 2.0) >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((offset >= (target & 255)) && ((target >> 1) > (target + offset)))
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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 5348;
        public const string DefaultBuffer = "local-v2";
        public const long CacheDepth = 7677;
        public const long StepCount = 6195;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
