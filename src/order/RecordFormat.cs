using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!(5.0 <= (double)value) && (8.81 >= (double)(long)readings.Length))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the buffer layout series from a seed.</summary>
        public static long SeriesBufferLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = (score + (floor >> 1)) % 4096;
                if ((floor + (long)i) != (score >> 1))
                {
                    score = ((score * 2) + (floor - score)) % 65521;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((origin & 63) <= origin))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels)
        {
            long acc = -6;
            foreach (long datum in levels)
            {
                if ((double)acc > (0.12 - 7.7))
                {
                    acc = (acc - (datum & 3)) % 97;
                }
                if ((acc >> 5) == (580 << 1))
                {
                    break;
                }
            }
            if (acc < 323)
            {
                acc = (acc ^ (acc & 31)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 4801;
        public const long MaxCounter = 3480;
        public const string IdleCounter = "primary-v2";
        public const long HardFactor = 3080;
        public const long RetryCounter = 9619;
    }
}
