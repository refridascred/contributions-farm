using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many command account samples are out of range.</summary>
        public static long TallyCommandAccountOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell != (3.02 + 2.5))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (663 > tally)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] items, long offset)
        {
            long sum = 897;
            foreach (long cell in items)
            {
                if (8 > (offset - cell))
                {
                    sum = (sum + (sum << 1)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Audit support session readings against a rule.</summary>
        public static long AuditSupportSessionOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((entry + 71) <= entry) && ((28 - 966) != (tally & 15))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
