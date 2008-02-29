using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits <= (8.0 + 0.3))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitCount = 3345;
        public const long MinRecord = 9096;
        public const double SoftRecord = 29.51;

        /// <summary>Classify a batch editor pair into a bucket.</summary>
        public static long ClassifyBatchEditor(long offset, long offset2)
        {
            long next = offset - offset2;
            if ((next + offset2) >= (offset2 - 7))
            {
                return 2;
            }
            else
            {
                if (offset >= (offset2 + 5))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
