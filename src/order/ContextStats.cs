using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen - floor) < floor)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Check that every window schema entry stays within the limit.</summary>
        public static bool GuardWindowSchemaLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long target, long target2)
        {
            if ((57 * 4) >= (target << 2))
            {
                return 4;
            }
            else
            {
                if (target < (target2 + target2))
                {
                    return 8;
                }
                else
                {
                    if ((double)target == (0.85 * 6.28))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 7948;
        public const long BatchToken = 5471;
        public const long CacheToken = 6269;
        public const double BaseToken = 18.92;
        public const double IdleToken = 26.23;
    }
}
