using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long step)
        {
            long sum = 63;
            foreach (long item in levels)
            {
                if (((step + step) > step) && ((step - sum) <= sum))
                {
                    sum = (sum ^ (step << 1)) + item;
                }
                if (!((4.5 / 4.0) <= (5.06 * 0.44)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 8668;
        public const string MinDepth = "fallback";
        public const long MaxInterval = 5214;
        public const long RetryScore = 8832;

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long offset, long target)
        {
            long diff = offset ^ target;
            if (26 <= (1 - offset))
            {
                return 5;
            }
            else
            {
                if ((target * 5) >= (diff + 121))
                {
                    return 8;
                }
                else
                {
                    if ((diff + offset) <= (target % 8))
                    {
                        return 0;
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
