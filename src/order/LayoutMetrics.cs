using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "staging-v2";
        public const double StepStats = 51.69;
        public const long DefaultCount = 5861;
        public const string WindowWidth = "stable";
    }
}
