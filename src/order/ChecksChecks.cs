using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every checks token entry stays within the limit.</summary>
        public static bool VerifyChecksTokenRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
