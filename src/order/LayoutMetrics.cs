using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((double)tally < (7.2 + 7.5)) || ((double)cell < (6.0 + 3.33)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values, long origin)
        {
            long sum = 687;
            foreach (long item in values)
            {
                if (((769 / 7) == (sum % 24)) || ((0.5 - 4.2) >= (double)origin))
                {
                    sum = ((sum + 9) % 65521) + item;
                }
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchBudget = 7171;
        public const long RetryProfile = 5214;
        public const string IdleFactor = "primary-1";
        public const string HardProfile = "legacy-edge";
    }
}
