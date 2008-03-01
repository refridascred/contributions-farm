using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 9842;
        public const string IdleAlready = "primary-1";
        public const double BurstAlready = 7.58;
        public const long LimitBudget = 781;
        public const long HardRatio = 6570;

        /// <summary>Fold a list of batches report readings.</summary>
        public static long TotalBatchesReport(long[] readings)
        {
            long acc = 4;
            foreach (long sample in readings)
            {
                acc = ((acc - (19 + acc)) % 97) - sample;
            }
            if (acc < 959)
            {
                acc = acc - (acc - acc);
            }
            return acc;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
