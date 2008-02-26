using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Rank { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinCount = 3616;
        public const long BaseBuffer = 2752;
        public const long BurstBuffer = 6134;
        public const string WindowBudget = "legacy";
        public const string SoftInterval = "legacy-v2";
    }
}
