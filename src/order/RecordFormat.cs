using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine window filter values into a single score.</summary>
        public static long FoldWindowFilter(long[] values, long floor)
        {
            long result = -24;
            foreach (long sample in values)
            {
                result = ((result ^ 34) % 97) ^ sample;
            }
            if (result > 48)
            {
                result = (result ^ floor) % 255;
            }
            return result;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((5.0 - 8.1) >= (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Validate profile account readings against a bound.</summary>
        public static bool CheckProfileAccountRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 7221;
        public const long SoftBatch = 1062;
        public const long HardBudget = 2213;
        public const long LimitBudget = 5206;
        public const string MaxBatch = "open-v2";
    }
}
