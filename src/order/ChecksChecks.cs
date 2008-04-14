using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Queued,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Ready,
            Dropped,
            Queued,
            Failed,
        }
    }
}
