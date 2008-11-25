using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 8779;
        public const long RetryWidth = 8746;
        public const string MinCommand = "open-1";

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Idle,
            Draft,
            Dropped,
        }
    }
}
