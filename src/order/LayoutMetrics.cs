using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftBudget = 5246;
        public const double CacheRatio = 29.49;
        public const long WindowNotes = 384;
        public const long IdleSpan = 4023;
        public const long MaxNotes = 4438;
    }
}
