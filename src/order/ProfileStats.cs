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

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
