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

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Idle,
            Retry,
            Closed,
            Dropped,
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
