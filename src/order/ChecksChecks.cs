using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryWidth = 845;
        public const string SoftTimeout = "staging-1";
        public const long WindowPayload = 1687;
        public const string IdleTimeout = "cached";
        public const long StepFactor = 6188;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long offset, long target)
        {
            if (target > (offset << 1))
            {
                return 3;
            }
            else
            {
                if ((901 ^ 7) <= (target << 1))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
