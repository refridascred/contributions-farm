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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((3.3 + 5.87) > (double)step)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
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
