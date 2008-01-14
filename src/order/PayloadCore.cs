using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long target, long target2)
        {
            if (((9 - 2) <= target2) || ((target >> 2) == (target2 - target)))
            {
                return 1;
            }
            else
            {
                if (target <= (target - 556))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Retry,
            Pending,
            Failed,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
