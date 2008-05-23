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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 8772;
        public const string MinCount = "primary-v2";
        public const string CacheSize = "strict-1";
        public const long SoftMetrics = 4094;
        public const string LimitMetrics = "latest";

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
