using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Pending,
            New,
            Failed,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 2839;
        public const long HardPayload = 3843;
        public const long HardWidth = 421;
        public const long BaseSpan = 1406;
        public const double DefaultTimeout = 47.71;
    }
}
