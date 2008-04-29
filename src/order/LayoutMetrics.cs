using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Ready,
            Pending,
            Failed,
            Retry,
        }
    }
}
