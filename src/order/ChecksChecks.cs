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

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepTimeout = 6920;
        public const long IdleProfile = 2504;
        public const long WindowCount = 1816;
        public const string BatchProfile = "staging-1";
        public const long DefaultRatio = 5664;
    }
}
