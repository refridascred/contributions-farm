using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Pending,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Draft,
            Active,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Paused,
            Closed,
            Ready,
        }
    }
}
