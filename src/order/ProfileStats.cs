using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultRatio = 4867;
        public const long WindowBudget = 1389;
        public const long MinCount = 5018;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Count { get; set; }
            public bool Level { get; set; }
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
