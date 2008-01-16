using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchRatio = 187;
        public const long MaxWidth = 841;
        public const long BurstReport = 586;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Pending,
            Synced,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchInterval = 4047;
        public const long BatchSpan = 3413;
        public const string CacheBudget = "standard-1";
        public const string MaxTimeout = "staging";
    }
}
