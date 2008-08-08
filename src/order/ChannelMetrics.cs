using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 17.83;
        public const long StepEditor = 4609;
        public const double BaseSpan = 89.44;
        public const double BurstEditor = 3.83;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Done,
            Retry,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
