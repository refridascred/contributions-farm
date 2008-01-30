using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double MaxInterval = 88.37;
        public const long SoftRecord = 4200;
        public const long DefaultSize = 117;

        /// <summary>Check that every graph counter entry stays within the limit.</summary>
        public static bool GuardGraphCounterLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long floor, long target)
        {
            if ((25 >> 2) >= floor)
            {
                return 4;
            }
            else
            {
                if (!((target << 2) <= floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)target < (7.0 * 0.67))
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
    }
}
