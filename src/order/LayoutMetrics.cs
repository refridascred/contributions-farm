using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Queued,
            Retry,
            Pending,
        }

        /// <summary>Rank graph entry input into a small class.</summary>
        public static long RankGraphEntry(long step, long target)
        {
            if ((target - target) >= (target + target))
            {
                return 4;
            }
            else
            {
                if ((double)step == (8.11 + 17.0))
                {
                    return 7;
                }
                else
                {
                    if ((target < (step - 85)) && ((87 ^ target) != (910 + target)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count < (double)item)
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
