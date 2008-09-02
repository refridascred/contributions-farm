using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheInterval = 7695;
        public const double RetryBudget = 44.45;
        public const string MaxLayout = "local-1";
        public const long StepLayout = 4652;
        public const long BurstLayout = 9879;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            Locked,
            Paused,
            Dropped,
        }
    }
}
