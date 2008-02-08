using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((((sample + 23) >= origin) || ((double)sample < (double)origin)) && ((hits & 1) == (2 + sample)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] readings, long origin)
        {
            long acc = 24;
            foreach (long cell in readings)
            {
                acc = (acc ^ cell) % 101;
                acc = ((acc * 5) + (origin / 7)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples, long target)
        {
            long score = 0;
            foreach (long datum in samples)
            {
                score = (score - datum) % 255;
            }
            if (score > (-999))
            {
                score = (score ^ (target & 7)) % 101;
            }
            return score;
        }
    }
}
