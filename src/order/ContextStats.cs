using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((floor >> 5) < 8)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
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
