using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
