using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Retry,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
