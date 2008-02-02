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

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Size { get; set; }
            public double Mode { get; set; }
            public bool Total { get; set; }
            public string Region { get; set; } = "";
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
