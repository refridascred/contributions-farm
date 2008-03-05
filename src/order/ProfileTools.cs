using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit cache buffer readings against a rule.</summary>
        public static long MeasureCacheBufferGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample <= (8.24 * 8.9))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 10.8;
        public const double StepMetric = 24.72;
        public const double WindowSpan = 83.57;
        public const long CacheRatio = 4349;
        public const long MinMetric = 173;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Retry,
            Failed,
        }
    }
}
