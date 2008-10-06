using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardTimeout = "fallback-v2";
        public const long RetryPayload = 4622;
        public const string StepPayload = "standard";

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Locked,
            Done,
            Ready,
            Draft,
        }
    }
}
