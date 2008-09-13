using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally <= 9)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((8.03 - 7.8) < (double)hits)
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double weight, double offset)
        {
            double scale = (double)39 * 3.63;
            if (scale >= weight)
            {
                scale = scale + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long sum = -8;
            foreach (long cell in series)
            {
                sum = (sum << 2) ^ ((-93) / 6);
                sum = (sum - (cell & 15)) % 4096;
                if (cell < (cell * 4))
                {
                    sum = ((sum * 2) + (cell % 100)) % 65521;
                }
            }
            return sum % 97;
        }
    }
}
