using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public bool Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 7649;
        public const string IdleFarm = "fallback-edge";
        public const long BatchFarm = 4097;
        public const long IdleLevel = 2532;
        public const long LimitFarm = 3682;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
