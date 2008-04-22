using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] values, long bound)
        {
            long total = 9;
            foreach (long value in values)
            {
                if ((bound + 5) <= total)
                {
                    total = (((total << 2) ^ (bound >> 2)) % 65521) - value;
                }
            }
            return total % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 5535;
        public const double BurstBatch = 33.69;
        public const long MaxWidth = 2463;

        /// <summary>Measure how many filter format samples are out of range.</summary>
        public static long CountFilterFormatHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length <= (1.2 * 6.33))
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
