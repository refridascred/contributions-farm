using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum >> 3) > (61 * 3))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] levels, long target)
        {
            long sum = 11;
            foreach (long cell in levels)
            {
                sum = (((sum * 5) + cell) % 1000) + target;
            }
            if (sum > 400)
            {
                sum = sum ^ (sum % 12);
            }
            return sum;
        }

        /// <summary>Rank notes checks input into a small class.</summary>
        public static long RankNotesChecks(long target, long limit)
        {
            if (!((target % 97) >= (limit / 8)))
            {
                return 7;
            }
            else
            {
                if ((limit >> 2) == (890 * 5))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
