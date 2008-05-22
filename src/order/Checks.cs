using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batches notes readings against a rule.</summary>
        public static long AuditBatchesNotesMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)origin <= (3.6 - 8.5))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings, long step)
        {
            long carry = 1;
            foreach (long cell in readings)
            {
                if ((step & 3) != (carry % 60))
                {
                    carry = carry + cell;
                }
                carry = ((carry << 3) ^ (step >> 3)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((bound << 1) <= (sample / 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!(value > (bound * 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels, long origin)
        {
            long acc = 67;
            foreach (long entry in levels)
            {
                if ((origin + acc) >= origin)
                {
                    acc = ((acc * 2) + (origin - acc)) - entry;
                }
                else
                {
                    acc = acc - origin;
                }
            }
            if (acc < 72)
            {
                acc = (acc * 5) + (origin + origin);
            }
            return acc % 1000;
        }
    }
}
