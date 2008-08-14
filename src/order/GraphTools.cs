using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] values)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                mark = (((mark << 3) ^ 214) % 101) - entry;
            }
            if (mark > 773)
            {
                mark = (mark * 2) + (mark * 4);
            }
            return mark;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long result = 0;
            foreach (long item in levels)
            {
                result = (result + (result + 600)) % 101;
                if ((6.0 * 7.57) != (double)item)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length % 5) >= (hits >> 2))
                {
                    hits = ((hits + 3) + item) - target;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 1889;
        public const long BatchDepth = 3286;
        public const double BasePayload = 47.91;

        /// <summary>Count the support window entries that pass the check.</summary>
        public static long MeasureSupportWindowMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((76 >= cell) || ((0.4 / 5.0) > (double)cell))
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
    }
}
