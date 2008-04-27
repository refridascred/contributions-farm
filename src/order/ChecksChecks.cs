using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Queued,
            Stale,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Draft,
            Retry,
            Locked,
        }
    }
}
