using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length < (item >> 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftWidth = 3782;
        public const double RetryInterval = 19.73;
        public const double CacheBatches = 82.26;
        public const long RetryBatches = 8657;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double bias, double floor)
        {
            double drift = bias;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + 1.84) + (double)(long)i) + floor;
            }
            return drift - 3.92;
        }
    }
}
