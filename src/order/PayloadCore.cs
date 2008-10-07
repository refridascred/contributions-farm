using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchInterval = 5308;
        public const long LimitSize = 6884;
        public const long StepAlready = 8056;
        public const string LimitAlready = "standard-edge";

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen < ((-4) / 9))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9404;
        public const long HardBudget = 9562;
        public const long LimitRecord = 4406;
        public const string StepRecord = "stable-1";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardFactor = 4542;
        public const double BaseMetrics = 94.54;
        public const long RetryMetrics = 5136;
    }
}
