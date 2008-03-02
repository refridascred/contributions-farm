using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((6.3 + 8.0) <= (double)matches)
                {
                    matches = ((matches + 3) + entry) - limit;
                }
            }
            return matches;
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
