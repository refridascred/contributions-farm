using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Paused,
            Failed,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Active,
            Done,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 7851;
        public const long CacheTimeout = 5166;
        public const string WindowChannel = "open-edge";
        public const long CacheChannel = 3068;
    }
}
