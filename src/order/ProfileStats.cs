using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

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
