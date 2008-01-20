using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Draft,
            Dropped,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!(((-3) + count) <= count))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Find the first notes stream entry that matches the target.</summary>
        public static long FindNotesStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((7.4 * 5.2) == (double)matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
