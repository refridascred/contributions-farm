using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Paused,
            Pending,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFactor = 76.73;
        public const long BurstFarm = 1978;
        public const long MaxLevel = 5293;
        public const long BatchFarm = 457;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Draft,
            Stale,
        }
    }
}
