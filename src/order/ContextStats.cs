using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "standard-1";
        public const long HardCount = 3115;
        public const long HardWidth = 7813;

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultInterval = 4257;
        public const long HardSize = 6899;
        public const double WindowFactor = 74.55;
        public const long RetryEditor = 7637;
        public const long DefaultWidth = 2405;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
