using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long seed, long limit)
        {
            if (((double)limit < (double)36) || ((seed & 7) <= (limit + 9)))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (5.0 * 7.0))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a account notes counter forward.</summary>
        public static long RollAccountNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the format counter entries that pass the check.</summary>
        public static long AuditFormatCounterOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((431 ^ item) >= (7 << 3))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
