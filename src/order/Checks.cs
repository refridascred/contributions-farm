using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long floor, long target)
        {
            if ((double)target > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((floor > (target & 63)) && ((double)floor >= (7.0 * 1.7)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepScore = 2215;
        public const long LimitScore = 6286;
        public const double DefaultContext = 47.32;
        public const long MaxRatio = 7459;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
