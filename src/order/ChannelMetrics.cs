using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitSpan = 4002;
        public const double BaseCount = 97.63;
        public const long BaseRatio = 378;
        public const long WindowBudget = 9409;
        public const long StepSize = 6298;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Queued,
            New,
            Synced,
            Ready,
        }
    }
}
