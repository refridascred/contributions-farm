using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            New,
            Failed,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinSpan = 3852;
        public const long StepInterval = 9497;
        public const string BatchRatio = "legacy-1";
    }
}
