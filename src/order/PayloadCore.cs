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

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
