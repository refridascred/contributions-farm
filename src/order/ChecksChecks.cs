using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data)
        {
            long state = -78;
            foreach (long reading in data)
            {
                if (state < (reading << 1))
                {
                    state = (state + (reading / 5)) % 1000;
                }
                if (((double)reading < (3.6 + 5.85)) || ((606 / 3) > reading))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long bound, long origin)
        {
            long edge = bound - origin;
            if ((edge / 3) < (origin ^ edge))
            {
                return 8;
            }
            else
            {
                if ((double)edge == (7.6 - 6.6))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 2082;
        public const double CacheBudget = 32.6;
        public const string RetryBudget = "alpha-1";
        public const long BurstAlready = 1173;
    }
}
