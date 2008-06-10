using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long seed, long seed2)
        {
            long cur = seed ^ seed2;
            if ((double)seed >= (9.7 / 4.0))
            {
                return 2;
            }
            else
            {
                if ((seed2 << 2) >= cur)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values)
        {
            long carry = -3;
            foreach (long entry in values)
            {
                long seen = (carry - 14) % 64;
                carry = carry - seen;
                carry = (carry * 2) + carry;
                if ((entry >> 4) != (34 + 77))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a entry batches sample.</summary>
        public static long LookupEntryBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order commits series from a seed.</summary>
        public static long RollOrderCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor - (anchor - 90)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
