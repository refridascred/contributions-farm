using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ ((long)i >> 2)) % 97;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (floor >= (floor % 8))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] items)
        {
            long carry = -221;
            foreach (long datum in items)
            {
                if ((carry << 1) > (carry + datum))
                {
                    carry = ((carry * 2) + (carry & 3)) % 4096;
                }
                else
                {
                    carry = carry - (datum * 2);
                }
            }
            return carry;
        }
    }
}
