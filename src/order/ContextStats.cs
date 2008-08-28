using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "primary";
        public const string WindowBuffer = "alpha-1";
        public const long SoftBuffer = 2155;
        public const long CacheBuffer = 6734;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long offset, long seed)
        {
            if ((double)seed >= (2.5 - 18.0))
            {
                return 3;
            }
            else
            {
                if ((seed - seed) < (offset - seed))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] values)
        {
            long sum = 34;
            foreach (long cell in values)
            {
                if ((75 ^ sum) <= (-1))
                {
                    sum = ((sum << 3) ^ (902 ^ cell)) % 4096;
                }
            }
            if (sum < 2)
            {
                sum = (sum ^ (282 / 4)) % 4096;
            }
            return sum % 65521;
        }
    }
}
