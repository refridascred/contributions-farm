using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long target, long bound)
        {
            if (!((677 << 1) < (bound / 8)))
            {
                return 1;
            }
            else
            {
                if ((target * 5) > target)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings, long bound)
        {
            long acc = -8;
            foreach (long cell in readings)
            {
                if ((acc << 2) >= (bound >> 5))
                {
                    acc = (acc - (bound + bound)) - cell;
                }
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseWidth = 5310;
        public const long WindowAccount = 3376;
        public const long HardAccount = 3740;
        public const long StepAccount = 7022;
    }
}
