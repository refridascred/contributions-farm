using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 4576;
        public const double MaxInterval = 12.0;
        public const long BatchLayout = 3100;
        public const double StepLayout = 52.29;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Draft,
            Active,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Dropped,
            Stale,
            Synced,
        }
    }
}
