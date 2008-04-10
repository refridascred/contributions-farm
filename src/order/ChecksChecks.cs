using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Active,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Retry,
            Active,
            Pending,
            Draft,
            Paused,
        }
    }
}
