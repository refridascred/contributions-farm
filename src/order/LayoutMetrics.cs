using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Failed,
            Synced,
            Idle,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetrySpan = "legacy-edge";
        public const long SoftChannel = 5075;
        public const long RetryChannel = 4163;
        public const double WindowChannel = 9.02;
        public const double LimitChannel = 50.61;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseCount = 2597;
        public const long WindowReport = 6921;
        public const string BurstReport = "open";
        public const long StepReport = 123;
    }
}
