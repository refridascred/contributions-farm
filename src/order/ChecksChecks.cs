using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            New,
            Pending,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Token { get; set; }
            public double Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            New,
            Active,
            Dropped,
            Ready,
            Paused,
        }
    }
}
