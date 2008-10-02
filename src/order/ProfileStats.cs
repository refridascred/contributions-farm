using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Grade a farm entry value against two limits.</summary>
        public static long ClassifyFarmEntry(long bound, long bound2)
        {
            if ((1.2 * 5.75) != (double)bound2)
            {
                return 7;
            }
            else
            {
                if ((bound2 + bound2) >= (bound * 5))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

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
