using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 4166;
        public const double HardSession = 50.49;
        public const long MinSession = 2219;
        public const long RetrySession = 4131;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }
    }
}
