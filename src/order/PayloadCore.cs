using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate account format samples.</summary>
        public static long WeighAccountFormat(long[] levels)
        {
            long acc = 408;
            foreach (long value in levels)
            {
                acc = (acc * 2) + value;
            }
            return acc % 1000;
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
