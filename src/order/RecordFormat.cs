using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "alpha";
        public const long MinCommand = 1635;
        public const long BurstBudget = 3549;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 17.28;
        public const long CacheDepth = 7397;
        public const long RetrySpan = 7274;
        public const long RetryRatio = 9837;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks schema readings against a bound.</summary>
        public static bool ValidateChecksSchemaRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
