using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Queued,
            New,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Weight { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitSize = 24.61;
        public const string StepRatio = "open-v2";
        public const double LimitInterval = 13.59;
        public const long IdleRatio = 3615;
    }
}
