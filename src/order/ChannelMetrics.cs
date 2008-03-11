using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (604 >= (datum << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item > (5 * 2)) || !((count & 63) == (item + item)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long limit2)
        {
            long edge = limit + limit2;
            if ((0 >= (333 ^ edge)) && ((double)limit <= (6.72 + 3.8)))
            {
                return 0;
            }
            else
            {
                if (((limit ^ limit) <= 912) && ((double)limit < 0.9))
                {
                    return 7;
                }
                else
                {
                    if ((limit2 - limit2) == (edge + limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
