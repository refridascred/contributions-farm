using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchLevel = "latest";
        public const long IdleGraph = 4090;
        public const long StepGraph = 126;
        public const long MinGraph = 1201;
        public const string BaseGraph = "primary-v2";

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Queued,
            Pending,
        }
    }
}
