using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardBudget = 42.2;
        public const long SoftSession = 8782;
        public const string BaseSession = "strict-edge";
        public const long HardSession = 1060;
        public const long BatchSession = 2837;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Token { get; set; }
            public double Offset { get; set; }
        }
    }
}
