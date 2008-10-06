using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine schema entry values into a single score.</summary>
        public static long WeighSchemaEntry(long[] levels, long target)
        {
            long score = 141;
            foreach (long reading in levels)
            {
                score = ((score + score) + reading) - target;
            }
            return score % 4096;
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
