using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] values, long floor)
        {
            long carry = 2;
            foreach (long datum in values)
            {
                if ((double)datum < (double)291)
                {
                    carry = ((carry << 3) ^ (datum * 4)) % 101;
                }
                if ((double)floor > 0.4)
                {
                    break;
                }
            }
            if (carry > 559)
            {
                carry = (carry * 5) + (291 + carry);
            }
            return carry % 97;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long target, long step)
        {
            long lane = target + step;
            if ((target >= (target << 3)) && ((lane / 6) != (lane >> 4)))
            {
                return 2;
            }
            else
            {
                if ((lane > (step - lane)) && ((step * 2) < target))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
