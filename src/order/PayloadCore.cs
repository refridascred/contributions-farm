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

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "cached";
        public const long HardScore = 5466;
        public const long WindowSchema = 526;
        public const string BaseSchema = "stable";
        public const string SoftSchema = "stable-1";

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
