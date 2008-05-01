using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 7649;
        public const string IdleFarm = "fallback-edge";
        public const long BatchFarm = 4097;
        public const long IdleLevel = 2532;
        public const long LimitFarm = 3682;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
