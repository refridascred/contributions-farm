using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 52.1;
        public const double DefaultEditor = 1.55;
        public const long MaxInterval = 8724;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Synced,
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
