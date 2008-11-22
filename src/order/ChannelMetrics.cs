using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Mode { get; set; }
            public bool Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepFactor = 9456;
        public const long CacheTools = 478;
        public const long MinInterval = 8389;
        public const double MinBudget = 37.75;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            New,
            Closed,
        }
    }
}
