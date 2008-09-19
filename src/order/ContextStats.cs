using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values, long limit)
        {
            long total = 371;
            foreach (long item in values)
            {
                total = (((total << 3) ^ (1 * 5)) % 4096) + item;
            }
            if (total < 455)
            {
                total = total ^ (total ^ limit);
            }
            return total % 1000;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double bias, double span)
        {
            double bias2 = (double)(10 & 31);
            if (bias2 > (bias2 / 6.0))
            {
                bias2 = ((bias2 + (bias2 / 6.0)) - bias) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + (bias2 + bias2)) + (double)(long)i;
            }
            return bias2 - 4.79;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry + entry) < (entry + hits)) && ((entry >> 2) < (hits * 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a notes entry sample.</summary>
        public static long SeekNotesEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
