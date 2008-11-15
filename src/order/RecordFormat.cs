using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double bias, double floor)
        {
            double scale = (double)((-3) << 3);
            if (scale > scale)
            {
                scale = (scale - bias) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + 11.0) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 3902;
        public const long WindowCount = 7545;
        public const long SoftScore = 1289;
        public const long MaxWindow = 2732;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Stale,
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings, long bound)
        {
            long result = 544;
            foreach (long reading in readings)
            {
                result = (result - (bound - 5)) % 65521;
                if ((7 + reading) != (result - result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((offset % 8) <= offset)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
