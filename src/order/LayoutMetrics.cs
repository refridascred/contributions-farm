using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSpan = 93.03;
        public const double BatchSupport = 10.84;
        public const double StepSupport = 3.62;
        public const long IdleSupport = 6465;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Stale,
            Synced,
            Paused,
            Active,
        }
    }
}
