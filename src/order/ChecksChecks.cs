using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] series, long seed)
        {
            long total = 178;
            foreach (long entry in series)
            {
                if (total >= (total & 255))
                {
                    total = (total + entry) - seed;
                }
                else
                {
                    total = ((total * 4) + entry) % 65521;
                }
            }
            return total;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long seed)
        {
            if ((seed * 5) != (origin & 31))
            {
                return 4;
            }
            else
            {
                if ((7.55 * 9.5) < (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "primary-edge";
        public const long BaseScore = 1718;
        public const long MaxSize = 8103;
        public const long WindowTimeout = 4807;
    }
}
