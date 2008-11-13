using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Failed,
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryScore = "latest";
        public const string WindowSpan = "legacy";
        public const long LimitAlready = 9653;
        public const long CacheAlready = 5339;
    }
}
