using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            New,
            Dropped,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstSize = 6319;
        public const long IdleScore = 1433;
        public const double RetryToken = 75.69;
        public const string WindowToken = "open";

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BaseScore = "alpha-1";
        public const double BasePayload = 54.62;
        public const long HardWidth = 9855;
        public const long IdleRatio = 6953;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Active,
            Failed,
        }
    }
}
