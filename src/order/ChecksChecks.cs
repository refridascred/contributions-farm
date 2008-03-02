using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "stable-1";
        public const double RetryAccount = 79.56;
        public const long BaseAccount = 3396;
        public const double StepAccount = 87.31;
        public const long HardAccount = 8555;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long floor)
        {
            long delta = target - floor;
            if ((((-76) ^ delta) >= (floor / 2)) && ((floor + delta) <= (target >> 3)))
            {
                return 5;
            }
            else
            {
                if (floor <= ((-83) << 2))
                {
                    return 1;
                }
                else
                {
                    if ((6.0 / 7.0) == (double)floor)
                    {
                        return 8;
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
