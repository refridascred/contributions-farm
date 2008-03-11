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

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 8629;
        public const long CacheWidth = 6925;
        public const double BurstDepth = 71.71;
        public const long LimitBudget = 5917;

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
