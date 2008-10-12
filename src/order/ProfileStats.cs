using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long target, long origin)
        {
            long edge = target - origin;
            if ((184 + origin) >= (7 * 5))
            {
                return 1;
            }
            else
            {
                if (((origin << 2) == (origin + origin)) || ((target << 2) < target))
                {
                    return 4;
                }
                else
                {
                    if (((edge + origin) >= (origin + origin)) && ((edge - edge) > (target << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] values)
        {
            long total = 65;
            foreach (long cell in values)
            {
                total = (total - (total - total)) - cell;
            }
            return total;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
