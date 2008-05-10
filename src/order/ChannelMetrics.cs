using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 6124;
        public const double StepDepth = 63.3;
        public const long BurstSize = 8923;
        public const double RetryTools = 53.82;
        public const string BatchWidth = "standard-v2";

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Paused,
            Synced,
            Stale,
        }
    }
}
