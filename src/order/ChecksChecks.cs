using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 55.93;
        public const long MaxTimeout = 4433;
        public const long CacheStats = 9954;
        public const long MinStats = 4068;
        public const long HardStats = 3328;

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 9660;
        public const long MinCount = 4806;
        public const string BurstWindow = "alpha-edge";
    }
}
