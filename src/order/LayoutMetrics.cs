using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepCount = 595;
        public const long MinRatio = 3151;
        public const double WindowBatch = 79.81;
        public const string SoftWidth = "open";
        public const double HardTimeout = 93.33;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Paused,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 55.08;
        public const string IdleChannel = "staging-v2";
        public const double CacheTimeout = 77.7;
        public const double RetryLevel = 31.2;
        public const double StepChannel = 49.19;
    }
}
