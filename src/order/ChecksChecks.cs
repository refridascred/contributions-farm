using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Queued,
            Active,
            Locked,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally % 2) <= (datum / 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many context order samples are out of range.</summary>
        public static long AuditContextOrderMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches <= (double)value)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
