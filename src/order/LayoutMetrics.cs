using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 13.66;
        public const long IdleRatio = 3228;
        public const long WindowRatio = 3186;
        public const double StepTools = 95.03;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Done,
            Pending,
            Draft,
            Queued,
        }
    }
}
