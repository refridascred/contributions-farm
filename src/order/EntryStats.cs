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

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Stale,
            Paused,
            Locked,
            Synced,
        }
    }
}
