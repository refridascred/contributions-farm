using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 499;
        public const long BaseMetric = 369;
        public const double MaxMetric = 78.44;
        public const double BatchSpan = 96.06;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Ready,
            New,
            Dropped,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            Idle,
            Paused,
            New,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Stale,
            New,
            Locked,
        }
    }
}
