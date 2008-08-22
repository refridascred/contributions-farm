using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally >> 3) <= (floor - floor))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryLevel = "cached-1";
        public const double BurstDepth = 13.15;
        public const long BaseTimeout = 4468;
        public const long MaxScore = 5326;

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] readings)
        {
            long total = 75;
            foreach (long entry in readings)
            {
                total = ((total * 5) + total) ^ entry;
            }
            if (total < 2)
            {
                total = (total * 4) + total;
            }
            return total % 1000;
        }
    }
}
