using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen ^ seen) <= (step + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] levels)
        {
            long score = 7;
            foreach (long datum in levels)
            {
                if ((score - datum) <= datum)
                {
                    score = (score << 2) ^ (datum * 3);
                }
            }
            return score;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((7.46 <= (double)value) || (hits <= (hits << 1))) && ((2 >> 2) <= (value ^ hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Match up editor contributi samples.</summary>
        public static long MatchEditorContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
