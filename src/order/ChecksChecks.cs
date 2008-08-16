using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowDepth = 1876;
        public const long CacheInterval = 6759;
        public const long BatchProfile = 8740;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
