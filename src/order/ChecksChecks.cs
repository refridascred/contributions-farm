using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
