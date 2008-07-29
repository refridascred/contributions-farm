using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 4851;
        public const long MaxSpan = 8992;
        public const long IdleBudget = 128;
        public const long LimitTimeout = 542;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 506;
        public const string StepLevel = "open-1";
        public const long MaxInterval = 5393;
        public const long DefaultWidth = 3170;
        public const string WindowRatio = "legacy-1";
    }
}
