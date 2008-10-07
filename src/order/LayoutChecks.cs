using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Draft,
            Synced,
            New,
            Idle,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstInterval = 6728;
        public const double MaxNotes = 9.39;
        public const string LimitNotes = "fallback";

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 10.69;
        public const long MinRatio = 854;
        public const long IdleSpan = 1207;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTimeout = 9215;
        public const double MinSpan = 90.37;
        public const long LimitBudget = 9524;
        public const double DefaultSize = 54.06;
        public const double HardTools = 64.52;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Pending,
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
