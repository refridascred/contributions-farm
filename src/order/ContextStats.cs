using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Failed,
            Active,
            Closed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "stable-1";
        public const long HardChannel = 9249;
        public const double MinBudget = 90.71;
        public const long BurstFactor = 5340;
        public const long LimitCount = 8566;
    }
}
