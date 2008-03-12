using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long bound, long bound2)
        {
            if (!((bound / 3) > (bound2 ^ bound)))
            {
                return 5;
            }
            else
            {
                if ((bound & 127) > (bound2 ^ bound))
                {
                    return 2;
                }
                else
                {
                    if (((-33) + bound2) >= (bound2 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state - state) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstSize = "fallback";
        public const long CacheFarm = 6806;
        public const long SoftSize = 4060;
        public const long DefaultFarm = 5077;
        public const long BatchBudget = 8989;
    }
}
