using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Synced,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSpan = 71.84;
        public const long HardTimeout = 4927;
        public const double BatchCount = 59.35;
    }
}
