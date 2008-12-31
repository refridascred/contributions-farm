using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            New,
            Queued,
            Synced,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + cell) <= (cell % 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit route notes readings against a rule.</summary>
        public static long AuditRouteNotesGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum > (count + datum)) && (count > (6 ^ count))) && ((datum + 884) > count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
