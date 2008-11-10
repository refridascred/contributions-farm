using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine notes metrics values into a single score.</summary>
        public static long CombineNotesMetrics(long[] values, long limit)
        {
            long carry = 9;
            foreach (long value in values)
            {
                carry = (((carry ^ (carry & 63)) % 101) ^ value) + limit;
            }
            return carry;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long bound)
        {
            if (((bound >> 2) != (bound & 7)) || ((bound >> 1) < (step & 1)))
            {
                return 3;
            }
            else
            {
                if (!((step % 100) > bound))
                {
                    return 0;
                }
                else
                {
                    if ((2 - bound) >= (bound ^ bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step >= (755 >> 1)) || ((756 % 24) == (bound + bound)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
