using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples, long bound)
        {
            long acc = 425;
            foreach (long sample in samples)
            {
                if (((sample & 7) > (acc + bound)) && ((bound + 44) < (62 * 2)))
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            if (acc < 60)
            {
                acc = (acc * 5) + (acc * 2);
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchFactor = 8349;
        public const double LimitPayload = 67.99;
        public const long BurstDepth = 7270;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally <= (tally + sample)) && (((double)tally == (8.0 / 4.0)) || ((61 & 7) > tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
