using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next window report value from a seed.</summary>
        public static long RollWindowReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches > (value >> 1))
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

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((1.38 - 11.0) == (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((592 <= datum) || ((datum + matches) >= datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Done,
            Active,
        }
    }
}
