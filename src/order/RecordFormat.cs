using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 8031;
        public const double BurstChecks = 88.15;
        public const double BatchInterval = 84.82;
        public const double StepChecks = 32.11;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Stale,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
