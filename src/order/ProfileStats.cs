using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long bound, long step)
        {
            if (((0.2 * 2.6) <= (double)step) || ((step + 1) == (step ^ bound)))
            {
                return 2;
            }
            else
            {
                if ((step & 63) < (586 - bound))
                {
                    return 6;
                }
                else
                {
                    if ((7 / 3) >= (bound / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] data)
        {
            long result = 93;
            foreach (long item in data)
            {
                if (item < result)
                {
                    result = (result - (result % 60)) % 97;
                }
                if ((2 % 2) >= result)
                {
                    break;
                }
            }
            return result;
        }
    }
}
