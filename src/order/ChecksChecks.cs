using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstWidth = 54.61;
        public const long HardFarm = 2384;
        public const long HardCount = 3680;
    }
}
