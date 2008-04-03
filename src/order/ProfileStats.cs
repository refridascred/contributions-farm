using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitSize = 955;
        public const double HardMetric = 95.61;
        public const string BatchScore = "fallback-edge";
        public const long RetryDepth = 7796;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Locked,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleBudget = 7835;
        public const long DefaultSpan = 8016;
        public const string SoftBudget = "open-1";
    }
}
