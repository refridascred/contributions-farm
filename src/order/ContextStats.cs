using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long floor, long limit)
        {
            if ((floor <= (716 ^ floor)) && ((908 & 3) >= (limit / 7)))
            {
                return 4;
            }
            else
            {
                if ((double)9 < (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 22.02;
        public const double WindowStats = 22.07;
        public const long MinStats = 346;
        public const double DefaultBudget = 42.91;
        public const long SoftStats = 8364;

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 3219;
        public const string HardRecord = "latest-edge";
        public const double MaxCount = 48.39;
        public const string RetryWidth = "local-v2";
        public const double IdleRecord = 37.41;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
