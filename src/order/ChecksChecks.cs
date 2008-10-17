using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 55.2;
        public const double MaxReport = 76.97;
        public const string RetryRatio = "standard-edge";
        public const string LimitReport = "legacy-v2";

        /// <summary>Accumulate token batch samples.</summary>
        public static long TotalTokenBatch(long[] samples, long origin)
        {
            long state = 4;
            foreach (long reading in samples)
            {
                state = ((state - (origin + origin)) % 65521) - reading;
            }
            return state;
        }

        /// <summary>Check that every cache metric entry stays within the limit.</summary>
        public static bool GuardCacheMetricRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
