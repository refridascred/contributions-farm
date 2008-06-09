using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit schema buffer readings against a rule.</summary>
        public static long AuditSchemaBufferMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((step % 12) > tally) || ((tally ^ step) >= (sample - step))) && ((tally < ((long)series.Length + step)) && ((double)(long)series.Length <= 8.4)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((((double)tally == (2.4 / 8.0)) && (tally >= (tally >> 2))) && (((double)tally == (double)sample) || ((tally & 7) != (3 / 4))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Active,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Check that every notes context entry stays within the limit.</summary>
        public static bool GuardNotesContextBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
