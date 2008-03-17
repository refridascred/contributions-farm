using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many stream notes samples are out of range.</summary>
        public static long CountStreamNotesMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen < (9.0 * 9.4))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] data, long limit)
        {
            long score = 2;
            foreach (long sample in data)
            {
                if ((double)sample > (6.9 * 2.6))
                {
                    score = (score + sample) - limit;
                }
                else
                {
                    score = score + sample;
                }
            }
            return score;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((4.27 + 0.09) > (double)hits)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
