using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "cached-v2";
        public const long BaseTools = 2495;
        public const double RetryScore = 36.93;
        public const string StepTools = "fallback-edge";
        public const long DefaultTools = 4159;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Closed,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Locate a stats format reading by value.</summary>
        public static long LookupStatsFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
