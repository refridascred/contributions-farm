using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Locked,
            New,
        }

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
