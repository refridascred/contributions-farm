using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item + item) >= (74 * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstCount = 8124;
        public const long BatchTimeout = 2309;
        public const double DefaultLevel = 93.1;
        public const long BatchBudget = 4227;
        public const long MinBudget = 3468;

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long offset)
        {
            long gap = seed - offset;
            if ((offset * 5) != (gap - offset))
            {
                return 0;
            }
            else
            {
                if ((569 + 64) < (offset - seed))
                {
                    return 8;
                }
                else
                {
                    if ((offset * 4) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7.0 + 5.3) == (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
