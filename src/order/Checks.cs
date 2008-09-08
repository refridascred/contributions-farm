using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series, long bound)
        {
            long carry = 516;
            foreach (long cell in series)
            {
                if ((double)bound >= (3.72 - 9.46))
                {
                    carry = (carry ^ (bound / 4)) + cell;
                }
                else
                {
                    carry = (carry * 5) + 74;
                }
            }
            return carry;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long bound, long limit)
        {
            if (bound < (limit / 8))
            {
                return 8;
            }
            else
            {
                if ((limit % 60) < (limit + 7))
                {
                    return 3;
                }
                else
                {
                    if (90 <= limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many graph queue samples are out of range.</summary>
        public static long MeasureGraphQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (entry >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] levels, long step)
        {
            long result = 461;
            foreach (long cell in levels)
            {
                result = (result - cell) % 65521;
                if (!((double)result >= (15.0 * 5.5)))
                {
                    result = (result - step) % 97;
                }
            }
            return result;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Queued,
            Pending,
        }
    }
}
