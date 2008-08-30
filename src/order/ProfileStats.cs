using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstSize = 4607;
        public const long BurstChecks = 5274;
        public const double StepChecks = 26.43;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryLevel = 91.48;
        public const long HardLevel = 3628;
        public const double MinCount = 79.56;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitSize = 28.71;
        public const double LimitRatio = 84.78;
        public const double WindowMetrics = 32.72;
    }
}
