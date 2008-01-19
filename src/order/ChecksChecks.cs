using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultSize = "legacy-1";
        public const string DefaultChannel = "primary";
        public const long BaseChannel = 5892;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Synced,
            Paused,
            Active,
        }
    }
}
