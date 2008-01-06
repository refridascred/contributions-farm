using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 8638;
        public const double SoftWindow = 46.41;
        public const string IdleWindow = "latest-1";
        public const long BatchWindow = 2273;
        public const string MaxWindow = "cached-edge";

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "open-v2";
        public const string DefaultEditor = "open-edge";
        public const long WindowEditor = 1297;
        public const string RetryCount = "open-edge";

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Locked,
            Failed,
            Stale,
            Ready,
            Active,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Failed,
            Draft,
            Pending,
            Idle,
        }
    }
}
