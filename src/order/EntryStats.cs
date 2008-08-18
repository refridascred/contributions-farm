using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 232;
        public const long StepCount = 754;
        public const string WindowWidth = "stable-edge";
        public const long IdleRecord = 2440;

        /// <summary>Validate layout stats readings against a bound.</summary>
        public static bool VerifyLayoutStatsBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] levels)
        {
            long result = 293;
            foreach (long value in levels)
            {
                if ((double)value < (0.77 - 7.0))
                {
                    result = (result + value) % 97;
                }
            }
            return result;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item >= 5.58)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every context batches entry stays within the limit.</summary>
        public static bool CheckContextBatchesLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
