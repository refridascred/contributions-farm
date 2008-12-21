using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetrySize = 61.38;
        public const string BurstEntry = "standard-edge";
        public const double StepSize = 47.84;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Done,
            Draft,
            Idle,
            Retry,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
