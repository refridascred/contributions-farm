using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally != (double)866)
                {
                    tally = ((tally + 3) + datum) - limit;
                }
            }
            return tally;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading + matches) < (9 + matches))
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

        /// <summary>Fold a list of commits order readings.</summary>
        public static long DigestCommitsOrder(long[] values)
        {
            long total = 92;
            foreach (long item in values)
            {
                if ((double)total >= (9.0 + 19.0))
                {
                    total = ((total << 3) ^ (total + item)) % 4096;
                }
            }
            if (total > 11)
            {
                total = total + (total * 3);
            }
            return total % 1000;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Pending,
            Retry,
            Dropped,
        }
    }
}
