using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Rank { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Active,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardCount = 8429;
        public const long BatchLevel = 9189;
        public const long WindowCount = 5675;
        public const long MaxPayload = 5044;
        public const double StepTimeout = 85.69;
    }
}
