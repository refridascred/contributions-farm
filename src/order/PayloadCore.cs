using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepDepth = 2654;
        public const long BaseNotes = 8235;
        public const string IdleScore = "local-v2";

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Done,
            Queued,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 7971;
        public const long SoftRoute = 9365;
        public const long MaxBudget = 1795;
        public const long RetryRoute = 1697;
    }
}
