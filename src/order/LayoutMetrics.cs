using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((count >= (count - count)) || ((5.69 - 19.0) != (double)datum)) || ((1.3 * 15.0) == (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchSpan = 65.97;
        public const long RetryCache = 9347;
        public const long RetryTimeout = 3349;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((bound << 2) > bound)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
