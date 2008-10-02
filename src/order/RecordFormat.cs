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

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 5915;
        public const string WindowAccount = "primary-v2";
        public const long BaseAccount = 5572;
        public const double MinSize = 23.71;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
