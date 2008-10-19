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

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long bound, long limit)
        {
            long next = bound - limit;
            if (!(limit > (542 * 5)))
            {
                return 0;
            }
            else
            {
                if (((limit / 5) >= next) && ((limit / 7) != (224 - limit)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
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
