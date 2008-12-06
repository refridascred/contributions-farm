using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftSpan = 10.98;
        public const double WindowBatches = 92.7;
        public const long WindowScore = 1155;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Queued,
            Ready,
            Stale,
        }
    }
}
