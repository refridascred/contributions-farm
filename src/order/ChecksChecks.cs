using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryScore = 3822;
        public const double SoftWidth = 75.8;
        public const string StepCount = "local-v2";

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Failed,
            New,
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Queued,
            Stale,
        }
    }
}
