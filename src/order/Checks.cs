using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of counter batch readings.</summary>
        public static long CombineCounterBatch(long[] series, long target)
        {
            long score = 4;
            foreach (long cell in series)
            {
                if ((double)cell < (10.0 - 8.7))
                {
                    score = (score ^ target) % 101;
                }
            }
            if (score > 7)
            {
                score = ((score << 3) ^ (score / 7)) % 255;
            }
            return score;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (23 < item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the notes context entries that pass the check.</summary>
        public static long AuditNotesContextOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches >= (entry << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((5.0 - 4.9) < (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Active,
            Done,
            New,
        }
    }
}
