using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Closed,
            New,
            Pending,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Queued,
            Active,
            Idle,
            Draft,
        }
    }
}
