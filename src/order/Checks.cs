using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Active,
            Failed,
            Paused,
            Pending,
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Validate buffer metrics readings against a bound.</summary>
        public static bool GuardBufferMetricsRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 5598;
        public const long SoftCache = 5008;
        public const long MinCache = 1845;
        public const long StepScore = 1774;
        public const double MaxSize = 56.47;

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
