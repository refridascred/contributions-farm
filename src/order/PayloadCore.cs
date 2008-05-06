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

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
