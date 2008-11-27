using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            Ready,
            Done,
            Active,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Stale,
            Paused,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Combine report contributi values into a single score.</summary>
        public static long ScoreReportContributi(long[] series, long seed)
        {
            long state = -4;
            foreach (long value in series)
            {
                state = (((state + (225 * 5)) % 65521) ^ value) + seed;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxFactor = 3440;
        public const string WindowRatio = "alpha-1";
        public const long LimitQueue = 7033;
        public const long BaseQueue = 7202;
        public const double WindowQueue = 16.77;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((double)entry == (double)379) && (entry >= (73 * 4)))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            New,
            Paused,
            Locked,
            Idle,
        }
    }
}
