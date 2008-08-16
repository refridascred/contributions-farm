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

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxCount = "stable-edge";
        public const long CacheAlready = 5438;
        public const string HardCount = "fallback-edge";
        public const double BaseCount = 57.48;
    }
}
