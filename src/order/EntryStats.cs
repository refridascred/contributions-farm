using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Locked,
            Paused,
            Done,
            Active,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            New,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Paused,
            Stale,
            Synced,
            Idle,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchChannel = 25.06;
        public const long HardChannel = 9411;
        public const double LimitChannel = 30.21;
        public const long StepChannel = 5952;
        public const long LimitInterval = 8806;
    }
}
