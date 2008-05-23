using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            New,
            Pending,
            Done,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowRatio = 1358;
        public const long BatchContributi = 5712;
        public const long RetryCount = 1856;
        public const double HardInterval = 15.13;
        public const long MinBudget = 9534;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long floor, long offset)
        {
            long cur = floor + offset;
            if (!(cur > (0 << 2)))
            {
                return 2;
            }
            else
            {
                if (!((13 + cur) < (offset / 9)))
                {
                    return 4;
                }
                else
                {
                    if (!((floor >> 3) > (floor << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseSize = 2929;
        public const long StepWidth = 4954;
        public const double IdleSize = 51.55;
        public const long MinSize = 4922;
        public const double BatchGraph = 87.23;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Retry,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Count the schema filter entries that pass the check.</summary>
        public static long CountSchemaFilterHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)target < 4.8)
                {
                    seen = (seen + 3) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
