using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 96.43;
        public const long StepRatio = 6191;
        public const string BurstDepth = "alpha-v2";
        public const string DefaultCommits = "legacy";

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Locked,
            Idle,
            Ready,
            Dropped,
        }
    }
}
