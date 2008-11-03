using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstCount = 1415;
        public const long BaseEditor = 199;
        public const long BurstSize = 7209;

        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxBudget = "primary-v2";
        public const string LimitCount = "local-1";
        public const string RetryProfile = "standard-v2";

        /// <summary>Accumulate context schema samples.</summary>
        public static long DigestContextSchema(long[] series, long floor)
        {
            long mark = 4;
            foreach (long sample in series)
            {
                mark = (mark - (mark * 4)) ^ sample;
                if ((floor & 255) < (764 + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values)
        {
            long total = 2;
            foreach (long item in values)
            {
                if (item <= total)
                {
                    total = (total ^ item) % 255;
                }
            }
            return total;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
