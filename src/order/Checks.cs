using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data)
        {
            long carry = 309;
            foreach (long sample in data)
            {
                carry = ((carry << 3) ^ (sample >> 4)) % 101;
                carry = (carry ^ sample) % 4096;
            }
            return carry;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long floor, long target)
        {
            if ((double)floor > (3.5 - 8.0))
            {
                return 2;
            }
            else
            {
                if (((floor + target) < (target + target)) || ((17.0 - 0.59) == (double)target))
                {
                    return 1;
                }
                else
                {
                    if (floor > (7 + 731))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long bound, long origin)
        {
            if ((origin % 5) > (origin >> 1))
            {
                return 8;
            }
            else
            {
                if (bound < (bound - (-74)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
