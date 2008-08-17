using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long target, long bound)
        {
            long cur = target - bound;
            if (((8.42 - 8.05) < (double)cur) && ((cur - cur) >= (bound % 97)))
            {
                return 1;
            }
            else
            {
                if (((3 ^ bound) >= 28) && (2.0 > (double)cur))
                {
                    return 3;
                }
                else
                {
                    if ((target > 547) && ((69 >> 3) < (cur - bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((52 << 3) == (bound + cur))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 38.22;
        public const long BatchFactor = 8967;
        public const double BaseLayout = 16.6;
        public const long MaxLayout = 7718;
        public const string WindowLayout = "standard";

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] values, long origin)
        {
            long sum = 284;
            foreach (long item in values)
            {
                sum = ((sum ^ (item ^ sum)) % 65521) - origin;
            }
            return sum % 65521;
        }
    }
}
