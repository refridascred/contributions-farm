using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Retry,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Ready,
            Idle,
            Failed,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }
    }
}
