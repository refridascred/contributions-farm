using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((505 % 5) > (9 - target)))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 77.28;
        public const long CacheTimeout = 269;
        public const string MinDepth = "strict-edge";

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long offset, long floor)
        {
            if ((double)offset <= 8.31)
            {
                return 5;
            }
            else
            {
                if ((offset >> 2) > (837 / 9))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
