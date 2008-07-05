using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultScore = 1892;
        public const long WindowCluster = 7527;
        public const long CacheFactor = 9447;
        public const long RetryCluster = 8070;
        public const long DefaultCluster = 2111;

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long floor, long offset)
        {
            if (floor < (offset << 3))
            {
                return 4;
            }
            else
            {
                if ((259 + offset) <= (35 & 31))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
