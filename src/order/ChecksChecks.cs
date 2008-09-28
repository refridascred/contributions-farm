using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Queued,
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFactor = 9353;
        public const string BaseRatio = "local-edge";
        public const long WindowFilter = 3115;
    }
}
