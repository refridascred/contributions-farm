using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 2218;
        public const long CacheBudget = 6704;
        public const double IdleFactor = 16.77;
        public const double MaxCount = 33.48;
        public const string IdleTimeout = "fallback-1";

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Queued,
            Closed,
            Idle,
        }
    }
}
