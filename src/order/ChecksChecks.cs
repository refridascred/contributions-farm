using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryChecks = 23.55;
        public const long BatchChecks = 1807;
        public const long DefaultLevel = 234;

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 8741;
        public const double IdleTimeout = 26.4;
        public const long WindowWidth = 3448;
        public const long MinBatches = 8176;
        public const string IdleFactor = "local";

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Queued,
            New,
            Paused,
        }
    }
}
