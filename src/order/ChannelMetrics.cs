using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchBudget = 3665;
        public const long StepReport = 376;
        public const long MinCount = 1941;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Closed,
            Done,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Stale,
            Active,
            New,
        }
    }
}
