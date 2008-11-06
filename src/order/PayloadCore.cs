using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 6946;
        public const long BatchWidth = 6561;
        public const long MaxAlready = 2456;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            Dropped,
            Locked,
            Synced,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Dropped,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 71.78;
        public const double MaxScore = 44.81;
        public const long SoftSpan = 3012;
    }
}
