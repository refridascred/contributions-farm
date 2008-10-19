using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitLevel = "fallback-v2";
        public const long BatchSpan = 2446;
        public const double MaxChecks = 83.06;

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Draft,
            Stale,
            Queued,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
