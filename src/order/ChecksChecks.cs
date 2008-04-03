using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((floor + floor) <= (tally * 2))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long target, long floor)
        {
            if ((target >> 3) <= target)
            {
                return 3;
            }
            else
            {
                if (((target + target) <= (target >> 2)) || ((double)target <= (1.7 + 2.7)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
