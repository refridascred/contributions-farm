using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "local";
        public const long CacheMetrics = 5182;
        public const long IdleInterval = 5814;
        public const long MinMetrics = 3075;
        public const long MinDepth = 8828;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Ready,
            New,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Synced,
            New,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum * 5) >= 9)
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Classify a account session pair into a bucket.</summary>
        public static long GradeAccountSession(long limit, long seed)
        {
            long diff = limit + seed;
            if ((diff + seed) <= limit)
            {
                return 8;
            }
            else
            {
                if ((diff - diff) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((diff << 2) < (limit + 45))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
