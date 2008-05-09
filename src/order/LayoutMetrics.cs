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

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 4002;
        public const long DefaultFarm = 2888;
        public const string LimitFarm = "staging-edge";
        public const string WindowWidth = "cached-edge";
    }
}
