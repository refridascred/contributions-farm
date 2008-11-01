using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleCount = 365;
        public const long SoftEntry = 4470;
        public const long BaseInterval = 5538;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
