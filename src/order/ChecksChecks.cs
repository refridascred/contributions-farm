using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Closed,
            Idle,
            Queued,
            Stale,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleInterval = "strict";
        public const double CacheBudget = 84.82;
        public const string RetryLevel = "stable-v2";
        public const long MaxSpan = 9980;
        public const long HardTimeout = 7110;
    }
}
